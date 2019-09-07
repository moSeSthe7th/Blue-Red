using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    private void Awake()
    {
        DataScript.currentLevel = PlayerPrefs.GetInt("Current Level", 1);
        DataScript.maxLevel = PlayerPrefs.GetInt("Max Level", 1);
        DataScript.totalLevelCount = 8;
        DataScript.pointCountToSelect = 2;
        DataScript.pointCountSelectedbyPlayer = 0;
        DataScript.pointCountSelectedByComputer = 0;
        DataScript.playerScore = 0;
        DataScript.computerScore = 0;
        DataScript.isSelectionLocked = false;
        DataScript.inputLock = false;
        DataScript.playerColor = Color.blue;
        DataScript.computerColor = Color.red;
        DataScript.defaultColor = Color.black;
        DataScript.pointList = new List<GameObject>();
    }
}
