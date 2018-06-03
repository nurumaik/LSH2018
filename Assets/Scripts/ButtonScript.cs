using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HandleMouseEnter()
    {
        GetComponentInChildren<Text>().color = new Color(1, 1, 1, 1);
    }

    public void HandleMouseExit()
    {
        GetComponentInChildren<Text>().color = new Color(1, 1, 1, 170f/255f);
    }
}
