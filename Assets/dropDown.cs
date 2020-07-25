using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dropDown : MonoBehaviour
{
    public static float newRespawnTime = 0.5f;
    public static string gameMode = "Difficulty";

    public void handleInputData(int val)
    {
        if (val == 0)
        {
             gameMode = "Difficulty";
		}
        if (val == 1)
        {
             newRespawnTime = 0.25f;
             gameMode = "easy";
             Debug.Log(newRespawnTime);
		}
        if (val == 2)
        {
              newRespawnTime = 0.05f;
              gameMode = "medium";
              Debug.Log(newRespawnTime);
		}
        if (val == 3)
        {
              newRespawnTime = 0.05f;
              gameMode = "hard";
              Debug.Log(newRespawnTime);
		}
    }

}
