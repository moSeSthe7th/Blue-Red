using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : MonoBehaviour
{
    public float cameraFOV;

    public List<Point> pointList;
    public struct Point
    {
        public Vector3 position;
        public Color color;

        public Point(Vector3 position, Color color)
        {
            this.position = position;
            this.color = color;
        }
    }

    public void LoadLevelData(int level)
    {
        List<Point> pointListInner = new List<Point>();

        switch (level)
        {
            case 1:
                pointListInner.Add(new Point(new Vector3(-4f, -4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(0, -4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(4f, -4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(4f, 0, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(4f, 4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(0, 4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-4f, 4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-4f, 0, 0f), DataScript.defaultColor));

                cameraFOV = 13.7f;
                break;
            case 2:
                pointListInner.Add(new Point(new Vector3(-4f, -4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(0, -4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(4f, -4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(2f, 0, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(0f, 4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-2f, 0, 0f), DataScript.defaultColor));

                cameraFOV = 13.7f;
                break;
            case 3:
                pointListInner.Add(new Point(new Vector3(-6f, -4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-2f, -4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(2f, -4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(6f, -4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(6f, 0, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(6f, 4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(2f, 4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-2f, 4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-6f, 4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-6f, 0, 0f), DataScript.defaultColor));

                cameraFOV = 17f;

                break;
            case 4:
                pointListInner.Add(new Point(new Vector3(0, 4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(2f, 4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(4f, 2f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(4f, 0, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(4f, -2f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(2f, -4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(0, -4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-2f, -4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-4f, -2f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-4f, 0, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-4f,2f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-2f, 4f, 0f), DataScript.defaultColor));

                cameraFOV = 17f;

                break;
            case 5:
                pointListInner.Add(new Point(new Vector3(0, 4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(2f, 2f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(4f, 0f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(2f, -2f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(0, -4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-2f, -2f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-4f, 0, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-2f, 2f, 0f), DataScript.defaultColor));
                

                cameraFOV = 17f;

                break;
            case 6:
                pointListInner.Add(new Point(new Vector3(0, 2f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(2f, 4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(4f, 2f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(2f, -1f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(0, -4f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-2f, -1f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-4f, 2f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-2f, 4f, 0f), DataScript.defaultColor));
                
                cameraFOV = 17f;

                break;
            case 7:
                
                pointListInner.Add(new Point(new Vector3(4f, -2f, 0f), DataScript.defaultColor));
                
                pointListInner.Add(new Point(new Vector3(2f, 4f, 0f), DataScript.defaultColor));
                
                pointListInner.Add(new Point(new Vector3(0, 0f, 0f), DataScript.defaultColor));
               
                pointListInner.Add(new Point(new Vector3(-2f, 4f, 0f), DataScript.defaultColor));
                
                pointListInner.Add(new Point(new Vector3(-4f, -2f, 0f), DataScript.defaultColor));

                cameraFOV = 17f;

                break;
            case 8:

                pointListInner.Add(new Point(new Vector3(0, 5f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(0.75f, 1f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(6f, 2.5f, 0f), DataScript.defaultColor));
                
                pointListInner.Add(new Point(new Vector3(2f, 0, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(2f, -5f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(0, -1f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-2f, -5f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-2f, 0f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-6f, 2.5f, 0f), DataScript.defaultColor));
                pointListInner.Add(new Point(new Vector3(-0.75f, 1f, 0f), DataScript.defaultColor));

                cameraFOV = 17f;

                break;
        }

        pointList = pointListInner;
    }
}
