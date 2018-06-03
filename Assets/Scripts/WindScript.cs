using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindScript : MonoBehaviour {

    public float maxSpeed = 4f;

    public GameObject windIndicator;

    public Vector2 force;

	// Use this for initialization
	void Start () {
        force = new Vector2(Random.Range(-maxSpeed, maxSpeed), 0f);
        windIndicator.transform.localScale = new Vector3(Mathf.Abs(maxSpeed / 10f), 1, 1);
        if (force.x < 0)
        {
            windIndicator.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else
        {
            windIndicator.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
