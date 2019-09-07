using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsPanelButton : MonoBehaviour
{
    private UIHandler uIHandler;
    
    public void OpenLevelsPanel()
    {
        uIHandler = FindObjectOfType(typeof(UIHandler)) as UIHandler;
        uIHandler.OpenLevelsPanel();
    }
}
