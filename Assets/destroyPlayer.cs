using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyPlayer : MonoBehaviour
{
    public GameObject Player;
    public AudioSource themeSong;

    void Start()
    {
        themeSong = GetComponent<AudioSource>();
        themeSong.Play();
	}

    void OnCollisionEnter2D(Collision2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            Destroy(player.gameObject);
        }  
        else if (player.gameObject.tag == "Player2")
        {
            SceneManager.LoadScene("Game 2");
		}
    }
}
