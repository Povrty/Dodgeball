using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startGame : MonoBehaviour
{
    public Text error;
    public dropDown callingScript;
    public static string chooseGameMode;

	public void Game()
    {   
        chooseGameMode = dropDown.gameMode;
        if (chooseGameMode == "Difficulty")
        {
            error.GetComponent<Text>().enabled = true;
		} 
        else 
        {
            SceneManager.LoadScene("Game 1");
		}
    }
}
