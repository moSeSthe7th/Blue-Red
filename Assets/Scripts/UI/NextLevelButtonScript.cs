using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButtonScript : MonoBehaviour
{
   

    public void NextLevel()
    {
        if(DataScript.currentLevel != DataScript.totalLevelCount)
        {
            if (DataScript.currentLevel == DataScript.maxLevel)
                DataScript.maxLevel++;
            DataScript.currentLevel++;
            PlayerPrefs.SetInt("Current Level", DataScript.currentLevel);
            PlayerPrefs.SetInt("Max Level", DataScript.maxLevel);
        }

        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
