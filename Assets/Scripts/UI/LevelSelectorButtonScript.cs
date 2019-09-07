using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectorButtonScript : MonoBehaviour
{
    public void OpenLevelWithNumber()
    {
        int levelNumber;
        int.TryParse(gameObject.GetComponentInChildren<Text>().text, out levelNumber);

        DataScript.currentLevel = levelNumber;
        PlayerPrefs.SetInt("Current Level", DataScript.currentLevel);

        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
