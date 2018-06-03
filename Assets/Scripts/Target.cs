using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public GameObject deadObject;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Utilities.genRandomVector(1.5f, 4f);
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnDestroy()
    {
        Instantiate(deadObject, transform.position, transform.rotation);
    }
}
