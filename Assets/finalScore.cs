using UnityEngine;
using UnityEngine.UI;

public class finalScore : MonoBehaviour
{
    public Text highScore;
    public replayGame callingScript;
    public float retrievedScore;
    public GameObject Player;
    public GameObject newScore;

    void Start()
    {
        highScore.text = PlayerPrefs.GetFloat("ScoreText", 0).ToString();
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
        
        if (retrievedScore > PlayerPrefs.GetFloat("ScoreText", 0))
        {
            PlayerPrefs.SetFloat("ScoreText", retrievedScore);
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
        PlayerPrefs.DeleteAll();
	}
}
