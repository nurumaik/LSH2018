using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var dir = GetComponent<Transform>().position;
        var delta = (pos - dir  ).normalized;
        float angle = Mathf.Atan2(delta.y, delta.x) * Mathf.Rad2Deg;
        GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, angle);
	}
}
