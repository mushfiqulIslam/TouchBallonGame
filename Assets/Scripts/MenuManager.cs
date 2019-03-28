using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	//void Update () {
	//	Debug.Log("Khela Choltese");
	//}
    //start the game
	public void PlayButtonPress () {
        SceneManager.LoadScene(1);
	}
    //end game
    public void ExitButtonPress()
    {
        Debug.Log("Khela sesh");
        Application.Quit();
    }
}
