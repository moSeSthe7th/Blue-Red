using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    public bool isColorized;
    public string pointColor1;
    public string pointColor2;
    public string combinedPointColor;

    public Sprite mixedColorSprite;

    private string defaultColorStr = "Default Color";
    private string playerColorStr = "Player Color";
    private string computerColorStr = "Computer Color";
    private string mixedColorStr = "Mixed Color";

    private void Start()
    {


        isColorized = false;
        pointColor1 = defaultColorStr;
        pointColor2 = defaultColorStr;
        combinedPointColor = defaultColorStr;
    }

    //burdan colorize olayını direk ilk bunu cağıranla yaparsak büyük ihtimal sıkıntı cıkmaz
    public void ColorizeThePoint(string colorOfPoint)
    {
        if (!isColorized)
        {
            
            if(colorOfPoint == playerColorStr)
            {
                //GetComponent<SpriteRenderer>().color = DataScript.playerColor;
                if(pointColor1 == defaultColorStr)
                {
                    pointColor1 = playerColorStr;
                    
                    
                }
                else if (pointColor2 == defaultColorStr)
                {
                    pointColor2 = playerColorStr;
                    isColorized = true;
                    DataScript.colorizedPointCount++;
                    //DataScript.playerScore++;
                    
                }
                
            }
            else if(colorOfPoint == computerColorStr)
            {
                //GetComponent<SpriteRenderer>().color = DataScript.computerColor;
                if (pointColor1 == defaultColorStr)
                {
                    pointColor1 = computerColorStr;
                   
                }
                else if(pointColor2 == defaultColorStr)
                {
                    pointColor2 = computerColorStr;
                    isColorized = true;
                    DataScript.colorizedPointCount++;
                    //DataScript.computerScore++;
                   
                }
            }

            if (pointColor1 == playerColorStr && pointColor2 == playerColorStr)
            {
                combinedPointColor = playerColorStr;
                GetComponent<SpriteRenderer>().color = DataScript.playerColor;
                
            }
            else if (pointColor1 == computerColorStr && pointColor2 == computerColorStr)
            {
                combinedPointColor = computerColorStr;
                GetComponent<SpriteRenderer>().color = DataScript.computerColor;

            }
            else if((pointColor1== playerColorStr && pointColor2 == computerColorStr) || (pointColor1 == computerColorStr && pointColor2 == playerColorStr))
            {
                combinedPointColor = mixedColorStr;
                GetComponent<SpriteRenderer>().sprite = mixedColorSprite;
                GetComponent<SpriteRenderer>().color = Color.white;
            }
        }
       
    }
}
