using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public int score = 0;
    public Text scorer;
 
	// Use this for initialization
	private void OnMouseDown () {
		score++;
        scorer.text = score.ToString();
	}
	
	
}
