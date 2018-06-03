using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindTarget : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<ConstantForce2D>().force = FindObjectOfType<WindScript>().force;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
