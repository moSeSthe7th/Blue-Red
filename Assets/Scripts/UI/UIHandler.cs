using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject levelPassedPanel;
    public GameObject settingsPanel;
    public GameObject levelsPanel;

    public Text drawOrGameOverText;
    public Button settingsButton;
    public Button exitButton;

    public Button levelPanelOpenerButton;
    
    void Start()
    {
        gameOverPanel.SetActive(false);
        levelPassedPanel.SetActive(false);
        settingsPanel.SetActive(false);
        levelsPanel.SetActive(false);
        exitButton.gameObject.SetActive(false);
    }

    public void GameOver(bool isDraw)
    {
        if (isDraw)
        {
            drawOrGameOverText.text = "DRAW!";
            gameOverPanel.SetActive(true);
        }

        else
        {
            drawOrGameOverText.text = "YOU LOST!";
            gameOverPanel.SetActive(true);
        }
            
    }
    public void LevelPassed()
    {
        levelPassedPanel.SetActive(true);
    }
    public void OpenCloseSettings()
    {
        DataScript.inputLock = true;
        if (settingsPanel.activeSelf)
        {
            settingsPanel.SetActive(false);
            settingsButton.gameObject.SetActive(true);
            exitButton.gameObject.SetActive(false);
        }
        else
        {
            settingsPanel.SetActive(true);
            settingsButton.gameObject.SetActive(false);
            exitButton.gameObject.SetActive(true);
        }
            
    }
    public void OpenLevelsPanel()
    {
        levelPanelOpenerButton.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(true);
        levelsPanel.SetActive(true);
        levelsPanel.GetComponent<LevelsPanelScript>().CreateLevelsPanel();
    }
    public void CloseAllPanels()
    {
        if (settingsPanel.activeSelf)
            settingsPanel.SetActive(false);
        if (levelsPanel.activeSelf)
        {
            levelsPanel.SetActive(false);
            levelPanelOpenerButton.gameObject.SetActive(true);
        }
            

        exitButton.gameObject.SetActive(false);
        settingsButton.gameObject.SetActive(true);
        DataScript.inputLock = false;
    }
}
