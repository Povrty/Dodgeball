using UnityEngine;
using UnityEngine.UI;

public class finalScore : MonoBehaviour
{
    public Text highScore;
    public replayGame callingScript;
    public dropDown callingScript2;
    public float retrievedScore;
    public static string chooseGameMode;
    public GameObject Player;
    public GameObject newScore;

    void Start()
    {
        chooseGameMode = dropDown.gameMode;
        if (chooseGameMode == "easy")
        {
            highScore.text = PlayerPrefs.GetFloat("ScoreTextEasy", 0).ToString();
		} 
        else if (chooseGameMode == "medium")
        {
            highScore.text = PlayerPrefs.GetFloat("ScoreTextMedium", 0).ToString();
		}
        else if (chooseGameMode == "hard")
        {
            highScore.text = PlayerPrefs.GetFloat("ScoreTextHard", 0).ToString();
		}
	}

    void Update()
    {
        if (Player == null)
        {
            updateScore();
		}
	}

    void updateScore()
    {
        retrievedScore = replayGame.score;
        
        if (chooseGameMode == "easy" && retrievedScore > PlayerPrefs.GetFloat("ScoreTextEasy", 0))
        {
            PlayerPrefs.SetFloat("ScoreTextEasy", retrievedScore);
            highScore.text = retrievedScore.ToString();
            newHighScore();
		}
        else if (chooseGameMode == "medium" && retrievedScore > PlayerPrefs.GetFloat("ScoreTextMedium", 0))
        {
            PlayerPrefs.SetFloat("ScoreTextMedium", retrievedScore);
            highScore.text = retrievedScore.ToString();
            newHighScore();
		}
        else if (chooseGameMode == "hard" && retrievedScore > PlayerPrefs.GetFloat("ScoreTextHard", 0))
        {
            PlayerPrefs.SetFloat("ScoreTextHard", retrievedScore);
            highScore.text = retrievedScore.ToString();
            newHighScore();
		}
	}

    void newHighScore()
    {
        newScore.GetComponent<Text>().enabled = true;
	}

    public void Reset()
    {
        if (chooseGameMode == "easy")
        {
            PlayerPrefs.DeleteKey("ScoreTextEasy");
        }
        else if (chooseGameMode == "medium")
        {
            PlayerPrefs.DeleteKey("ScoreTextMedium");
        }
        else if (chooseGameMode == "hard")
        {
            PlayerPrefs.DeleteKey("ScoreTextHard");
        }
	}
}
