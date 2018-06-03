using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

    public Text scoreText;

	// Use this for initialization
	void Start () {
        scoreText.text = "Score: " + UltraGodScript.LastScore + "/" + UltraGodScript.LastMaxScore;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
