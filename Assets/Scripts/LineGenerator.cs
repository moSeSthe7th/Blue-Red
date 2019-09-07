using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour
{
    private string defaultColorStr = "Default Color";
    private string playerColorStr = "Player Color";
    private string computerColorStr = "Computer Color";
    private string mixedColorStr = "Mixed Color";

    public GameObject lineObject;
    private List<Vector3> linePositions = new List<Vector3>();

    private GameController gameController;

    int totalLineCount = 0;

    private void DrawLine(Color color1, Vector3 position1, Color color2, Vector3 position2)
    {
        Vector3 currentLinePos = (position1 + position2) / 2;


        if (!linePositions.Contains(currentLinePos))
        {
            linePositions.Add(currentLinePos);
            totalLineCount++;
            Debug.Log("Total Line Count: " + totalLineCount);

            GameObject currentLine = Instantiate(lineObject);
            LineRenderer currentLineRenderer = currentLine.GetComponent<LineRenderer>();
            
            currentLineRenderer.SetPosition(0, position1);
            currentLineRenderer.SetPosition(1, position2);

            if (color1 == DataScript.defaultColor || color1 == null)
            {
                if (color2 == DataScript.playerColor)
                    DataScript.playerScore++;
                else
                    DataScript.computerScore++;

                currentLineRenderer.startColor = color2;
                currentLineRenderer.endColor = color2;
            }
            else if (color2 == DataScript.defaultColor || color2 == null)
            {
                if (color1 == DataScript.playerColor)
                    DataScript.playerScore++;
                else
                    DataScript.computerScore++;

                currentLineRenderer.startColor = color1;
                currentLineRenderer.endColor = color1;
            }
            else if(color1 == color2 && color1 == DataScript.playerColor)
            {
                DataScript.playerScore++;
               
                currentLineRenderer.startColor = color1;
                currentLineRenderer.endColor = color1;
            }
            else if(color1 == color2 && color1 == DataScript.computerColor)
            {
                DataScript.computerScore++;

                currentLineRenderer.startColor = color1;
                currentLineRenderer.endColor = color1;
            }
            else
            {
                currentLineRenderer.startColor = color1;
                currentLineRenderer.endColor = color2;
            }
        }
    }

    public void GenerateLinesBetweenPoints()
    {
        List<int> colorizedPointIndexes = new List<int>();

        foreach (GameObject p in DataScript.pointList)
        {
            if (p.GetComponent<PointScript>().isColorized)
            {
                colorizedPointIndexes.Add(DataScript.pointList.IndexOf(p));
            }
        }

       
        for(int k = 0; k<DataScript.totalPointCountInLevel; k++)
        {
            List<int> colorizedPointDummy = new List<int>();
            colorizedPointDummy.Clear();

            for (int i = 0; i < 2; i++)
            {
                foreach (int indexof in colorizedPointIndexes)
                {
                    GameObject selectedPoint = DataScript.pointList[indexof];
                    List<GameObject> closestPoints = FindClosestTwoPoints(indexof);
                    Color selectedPointColor = new Color();
                    Color color1 = DataScript.defaultColor;
                    Color color2 = DataScript.defaultColor;

                    selectedPointColor = SetColorOfPoint(selectedPoint);
                    color1 = SetColorOfPoint(closestPoints[0]);
                    color2 = SetColorOfPoint(closestPoints[1]);

                    DrawLine(selectedPointColor, selectedPoint.transform.position, color1, closestPoints[0].transform.position);
                    closestPoints[0].GetComponent<PointScript>().ColorizeThePoint(selectedPoint.GetComponent<PointScript>().combinedPointColor);
                    
                    DrawLine(selectedPointColor, selectedPoint.transform.position, color2, closestPoints[1].transform.position);
                    closestPoints[1].GetComponent<PointScript>().ColorizeThePoint(selectedPoint.GetComponent<PointScript>().combinedPointColor);

                    if (i == 0 && (!colorizedPointDummy.Contains(DataScript.pointList.IndexOf(closestPoints[0])) ||
                        !colorizedPointDummy.Contains(DataScript.pointList.IndexOf(closestPoints[1]))))
                    {
                        colorizedPointDummy.Add(DataScript.pointList.IndexOf(closestPoints[0]));
                        colorizedPointDummy.Add(DataScript.pointList.IndexOf(closestPoints[1]));
                    }
                }
            }

            colorizedPointIndexes = colorizedPointDummy;

        }

        gameController = FindObjectOfType(typeof(GameController)) as GameController;
        StartCoroutine(gameController.CheckForEndgame());
    }

    private Color SetColorOfPoint(GameObject point)
    {
        if (point.GetComponent<PointScript>().combinedPointColor == playerColorStr)
            return DataScript.playerColor;
        else if (point.GetComponent<PointScript>().combinedPointColor == computerColorStr)
            return DataScript.computerColor;
        else
            return DataScript.defaultColor;
    }

    
    private List<GameObject> FindClosestTwoPoints(int index)
    {
        List<GameObject> closestPoints = new List<GameObject>();
        closestPoints.Clear();

        if(index == 0)
        {
            closestPoints.Add(DataScript.pointList[1]);
            closestPoints.Add(DataScript.pointList[DataScript.pointList.Count - 1]);
        }
        else if(index == DataScript.pointList.Count - 1)
        {
            closestPoints.Add(DataScript.pointList[0]);
            closestPoints.Add(DataScript.pointList[DataScript.pointList.Count - 2]);
        }
        else
        {
            closestPoints.Add(DataScript.pointList[index + 1]);
            closestPoints.Add(DataScript.pointList[index - 1]);
        }

        return closestPoints;
    }

    
}





//eskiden setcolorofpoint fonksiyonu yerine kullanılan kod...
/*if (selectedPoint.GetComponent<PointScript>().combinedPointColor == playerColorStr)
    selectedPointColor = DataScript.playerColor;
else if (selectedPoint.GetComponent<PointScript>().combinedPointColor == computerColorStr)
    selectedPointColor = DataScript.computerColor;
else
    selectedPointColor = DataScript.defaultColor;


if (closestPoints[0].GetComponent<PointScript>().combinedPointColor == playerColorStr)
    color1 = DataScript.playerColor;
else if (closestPoints[0].GetComponent<PointScript>().combinedPointColor == computerColorStr)
    color1 = DataScript.computerColor;
else
    color1 = DataScript.defaultColor;


if (closestPoints[1].GetComponent<PointScript>().combinedPointColor == playerColorStr)
    color2 = DataScript.playerColor;
else if (closestPoints[1].GetComponent<PointScript>().combinedPointColor == computerColorStr)
    color2 = DataScript.computerColor;
else
    color2 = DataScript.defaultColor;*/
