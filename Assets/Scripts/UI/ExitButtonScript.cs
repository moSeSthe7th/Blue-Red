using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonScript : MonoBehaviour
{
    private UIHandler uIHandler;

    public void CloseAllPanels()
    {
        uIHandler = FindObjectOfType(typeof(UIHandler)) as UIHandler;
        uIHandler.CloseAllPanels();
    }
}
