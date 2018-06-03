using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBounty : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDestroy()
    {
        FindObjectOfType<GodScript>().AddTime();
    }
}
