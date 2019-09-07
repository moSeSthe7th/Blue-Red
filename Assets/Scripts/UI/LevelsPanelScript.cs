using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsPanelScript : MonoBehaviour
{
    public GameObject levelButtonObj;
    public GameObject Content;

    private bool isPanelCreated = false;

   public void CreateLevelsPanel()
    {
        if (!isPanelCreated)
        {
            for (int i = 1; i <= DataScript.totalLevelCount; i++)
            {
                GameObject obj = Instantiate(levelButtonObj);
                obj.gameObject.GetComponentInChildren<Text>().text = i.ToString();
                obj.transform.SetParent(Content.transform);

                if (i > DataScript.maxLevel)
                    obj.gameObject.GetComponentInChildren<Button>().interactable = false;

            }
            isPanelCreated = true;
        }
        
    }
}
