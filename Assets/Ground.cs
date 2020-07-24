using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D ball)
    {
        if (ball.gameObject.tag == "Ball")
        {
            Destroy(ball.gameObject);
            Debug.Log("Ground Hit");
        }
    }
}
