using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuideImageScript : MonoBehaviour
{
    public Sprite[] guideSprites;

    void Start()
    {
        GetComponent<Image>().sprite = guideSprites[DataScript.currentLevel - 1];
    }

    
}
