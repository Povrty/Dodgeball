using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorialGuide : MonoBehaviour
{

    public Text guidingText;
    public int checkRunningCoroutine = 0;

    void Start()
    {
        StartCoroutine(showMessages(3));

    }

    IEnumerator showMessages(int delay)
    {
       showMessage("Press the left and right arrows to move around.");
       yield return new WaitForSeconds(delay);
       guidingText.enabled = false;
       showMessage("Press the spacebar to jump.");
       yield return new WaitForSeconds(delay);
       guidingText.enabled = false;
       showMessage("Avoid the raining dodgeballs.");
       yield return new WaitForSeconds(delay);
       guidingText.enabled = false;
       showMessage("Try to get the longest time!");
       yield return new WaitForSeconds(delay);
       guidingText.enabled = false;
       showMessage("Press the menu button when you're done practicing!");
       yield return new WaitForSeconds(delay);
       guidingText.enabled = false;
	}
   
    public void showMessage(string message)
    {
       guidingText.text = message;
       guidingText.enabled = true;
    }
}
