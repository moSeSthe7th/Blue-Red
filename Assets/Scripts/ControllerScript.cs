using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    private string defaultColorStr = "Default Color";
    private string playerColorStr = "Player Color";
    private string computerColorStr = "Computer Color";

    private Vector2 mousePos;
    private Vector2 touchPos;

    private int computerSelectedPointCount = 0;

    private LineGenerator lineGenerator;

    void Update()
    {
        #region Mouse Controls
        if (Input.GetMouseButtonDown(0) && !DataScript.inputLock)
        {
            DataScript.inputLock = true;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D raycastHit2D = Physics2D.Raycast(mousePos, Vector2.zero);

            if(raycastHit2D.collider != null && raycastHit2D.collider.gameObject.tag == "Point" /*&& !DataScript.isSelectionLocked*/ && !raycastHit2D.collider.gameObject.GetComponent<PointScript>().isColorized)
            {
                raycastHit2D.collider.gameObject.GetComponent<SpriteRenderer>().color = DataScript.playerColor;
                for (int j = 0; j < 2; j++)
                {
                    raycastHit2D.collider.gameObject.GetComponent<PointScript>().ColorizeThePoint(playerColorStr);
                }


                DataScript.pointCountSelectedbyPlayer++;
                

                if(DataScript.pointCountSelectedbyPlayer <= DataScript.pointCountToSelect)
                {
                    //DataScript.isSelectionLocked = true;
                    SelectRandomPoints();
                }
            }
        }
        #endregion

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                touchPos = Camera.main.ScreenToWorldPoint(touch.position);

                RaycastHit2D raycastHit2D = Physics2D.Raycast(touchPos, Vector2.zero);

                if (raycastHit2D.collider != null && raycastHit2D.collider.gameObject.tag == "Point" && !DataScript.isSelectionLocked && !raycastHit2D.collider.gameObject.GetComponent<PointScript>().isColorized)
                {
                    raycastHit2D.collider.gameObject.GetComponent<SpriteRenderer>().color = DataScript.playerColor;
                    for (int j = 0; j < 2; j++)
                    {
                        raycastHit2D.collider.gameObject.GetComponent<PointScript>().ColorizeThePoint(playerColorStr);
                    }


                    DataScript.pointCountSelectedbyPlayer++;

                    if (DataScript.pointCountSelectedbyPlayer == DataScript.pointCountToSelect)
                    {
                        DataScript.isSelectionLocked = true;
                        SelectRandomPoints();
                    }
                }
            }
        }
    }

    void SelectRandomPoints()
    {
        GameObject[] points = GameObject.FindGameObjectsWithTag("Point");
        computerSelectedPointCount = 0;
        
        while (computerSelectedPointCount < 1)
        {
            int i = Random.Range(0, points.Length);
            GameObject selectedPoint = points[i];

            if(selectedPoint.GetComponent<SpriteRenderer>().color == DataScript.defaultColor)
            {
                selectedPoint.GetComponent<SpriteRenderer>().color = DataScript.computerColor;
                for(int j= 0; j < 2; j++)
                {
                    selectedPoint.GetComponent<PointScript>().ColorizeThePoint(computerColorStr);
                }

                computerSelectedPointCount++;
                DataScript.pointCountSelectedByComputer++;
            }
        }
       
        DataScript.inputLock = false;
       
        if(DataScript.pointCountSelectedByComputer == DataScript.pointCountToSelect)
        {
            lineGenerator = FindObjectOfType(typeof(LineGenerator)) as LineGenerator;
            lineGenerator.GenerateLinesBetweenPoints();
        }
        
    }
}
