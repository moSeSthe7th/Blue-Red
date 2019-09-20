using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusMinusImageScript : MonoBehaviour
{
    private Image plusMinusImage;
    public float pingPongLength;

    public Sprite minusImage;
   
    public void CreatePlusMinusForLine(GameObject line)
    {
        plusMinusImage = GetComponent<Image>();
      
        LineRenderer lineRenderer = line.GetComponent<LineRenderer>();
        Color startColor = lineRenderer.startColor;
        Color endColor = lineRenderer.endColor;

        if(startColor == DataScript.playerColor && endColor == DataScript.playerColor)
        {
            plusMinusImage.color = DataScript.playerColor;
            transform.position = (lineRenderer.GetPosition(0) + lineRenderer.GetPosition(1))/2;
            StartCoroutine(FlyTheUI());
        }
        else if(startColor == DataScript.computerColor && endColor == DataScript.computerColor)
        {
            plusMinusImage.color = DataScript.computerColor;
            transform.position = (lineRenderer.GetPosition(0) + lineRenderer.GetPosition(1)) / 2;
            plusMinusImage.sprite = minusImage;
            StartCoroutine(FlyTheUI());

        }
        else
        {
            gameObject.SetActive(false);
        }
        
    }

    IEnumerator FlyTheUI()
    {
        float posvecXrange = Random.Range(-0.03f, 0.03f);
        while(true)
        {
            Color plusMinusImageColor = plusMinusImage.color;
            Vector3 posVec = transform.position;
            posVec.y += 0.15f;

            posVec.x += posvecXrange;
            transform.position = posVec;
            plusMinusImageColor.a -= 0.01f;
            plusMinusImage.color = plusMinusImageColor;
            yield return new WaitForSecondsRealtime(0.001f);
        }
       
    }
}
