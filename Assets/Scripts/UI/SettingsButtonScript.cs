using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButtonScript : MonoBehaviour
{
    private UIHandler uIHandler;

    public void OpenSettingsPanel()
    {
        uIHandler = FindObjectOfType(typeof(UIHandler)) as UIHandler;
        uIHandler.OpenCloseSettings();
    }
}
