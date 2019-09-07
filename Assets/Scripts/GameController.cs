using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private UIHandler uIHandler;
   
    public IEnumerator CheckForEndgame()
    {
        yield return new WaitForSecondsRealtime(1f);
        uIHandler = FindObjectOfType(typeof(UIHandler)) as UIHandler;

        Debug.Log("Player Point count: " + DataScript.playerScore);
        Debug.Log("Computer Point Count: " + DataScript.computerScore);


        if (DataScript.playerScore == DataScript.computerScore)
        {
            uIHandler.GameOver(true);
            Debug.Log("Draw");
        }
            
        else if (DataScript.playerScore > DataScript.computerScore)
        {
            Debug.Log("Player Win");
            uIHandler.LevelPassed();
        }

        else
        {
            uIHandler.GameOver(false);
            Debug.Log("Player Lose");
        }
            
    }
}
