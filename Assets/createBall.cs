using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBall : MonoBehaviour
{
    public GameObject ballPrefab;
    public float respawnTime;
    private Vector2 screenBounds;
    public dropDown callingScript;

    void Start()
    {
        respawnTime = dropDown.newRespawnTime;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(ballWave());   
    }

    void spawnBall()
    {       
        GameObject a = Instantiate(ballPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y);
    }

    IEnumerator ballWave() {
        while(true) {
            yield return new WaitForSeconds(respawnTime);
            spawnBall();
		}
	}
}
