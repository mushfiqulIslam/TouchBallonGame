using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    // Restart is for starting from GameOver Menu
    public void RestartButtonPressed()
    {
        SceneManager.LoadScene(1);
    }
    // Play is for starting from GameOver Menu
    public void PlayButtonPressed()
    {
        SceneManager.LoadScene(1);
    }
    //Exit is for ending
    public void ExitButtonPressed()
    {
        Application.Quit();
    }
}
