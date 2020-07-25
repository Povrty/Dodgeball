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
    public bool ranOnce;

    void Start()
    {
        chooseGameMode = dropDown.gameMode;
        ranOnce = false;
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
        if (Player == null && ranOnce == false)
        {
            updateScore();
		}
	}

    void updateScore()
    {
        retrievedScore = replayGame.score;
        
        if (chooseGameMode == "easy" && retrievedScore > PlayerPrefs.GetFloat("ScoreTextEasy", 0))
        {
            updateLevel("ScoreTextEasy");
		}
        else if (chooseGameMode == "medium" && retrievedScore > PlayerPrefs.GetFloat("ScoreTextMedium", 0))
        {
            updateLevel("ScoreTextMedium");
		}
        else if (chooseGameMode == "hard" && retrievedScore > PlayerPrefs.GetFloat("ScoreTextHard", 0))
        {
            updateLevel("ScoreTextHard");
		}
	}

    void newHighScore(bool outcome)
    {
        newScore.GetComponent<Text>().enabled = outcome;
	}

    public void Reset()
    {
        if (chooseGameMode == "easy")
        {
            Difficulty("ScoreTextEasy");
        }
        else if (chooseGameMode == "medium")
        {
            Difficulty("ScoreTextMedium");
        }
        else if (chooseGameMode == "hard")
        {
            Difficulty("ScoreTextHard");
        }
	}

    public void Difficulty(string level)
    {
        PlayerPrefs.DeleteKey(level);
        newHighScore(false);
        highScore.text = "0";  
	}

    public void updateLevel(string level)
    {
        PlayerPrefs.SetFloat(level, retrievedScore);
        ranOnce = true;
        highScore.text = retrievedScore.ToString();
        newHighScore(true);  
	}
}
