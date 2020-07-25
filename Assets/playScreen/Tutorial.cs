using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public dropDown callingScript;
    public static string chooseGameMode;
    
	public void startTutorial()
    {
        chooseGameMode = dropDown.gameMode;
        SceneManager.LoadScene("Game 2");
    }
}
