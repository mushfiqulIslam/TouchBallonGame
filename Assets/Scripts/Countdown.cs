using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Countdown : MonoBehaviour {
    public int timer = 30;
    public Text countdowntxt;
	// Use this for initialization
	void Start () {
        Invoke("decreaseTime", 1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void decreaseTime()
    {
        countdowntxt.text = timer.ToString();
        if (timer > 0)
        {
            timer--;
            countdowntxt.text = timer.ToString();
            Invoke("decreaseTime", 1f);

        }
        else
        {
            //go to gameOver Scene
            SceneManager.LoadScene(2);
        }
    }
}
