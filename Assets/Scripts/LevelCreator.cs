using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{
    public GameObject point;

    private List<LevelData.Point> pointList;
    private LevelData levelData;

    private float cameraFOV;

    void Start()
    {
        levelData = FindObjectOfType(typeof(LevelData)) as LevelData;
        CreateLevel();
    }

    private void CreateLevel()
    {
      
        levelData.LoadLevelData(DataScript.currentLevel);
        cameraFOV = levelData.cameraFOV;

        pointList = levelData.pointList;

        for(int i = 0; i < pointList.Count; i++)
        {
            GameObject currentPoint = Instantiate(point, pointList[i].position, Quaternion.identity);
            currentPoint.GetComponent<SpriteRenderer>().color = pointList[i].color;
            DataScript.totalPointCountInLevel++;
            DataScript.pointList.Add(currentPoint);
        }

        OrthographicCameraScaler orthographicCameraScaler = FindObjectOfType(typeof(OrthographicCameraScaler)) as OrthographicCameraScaler;
        orthographicCameraScaler.SetCameraScale(cameraFOV);
    }
}
