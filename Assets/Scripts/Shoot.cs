using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public Rigidbody2D bulletTemplate;
    public float shootSpeed = 2f;
    public GameObject shootingStart;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            InvokeRepeating("LaunchProjectile", 0f, 0.5f);
        }
        if (Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(0))
        {
            CancelInvoke("LaunchProjectile");
        }
    }

    void LaunchProjectile ()
    {
        var start = shootingStart.transform.position;
        var angle = transform.rotation.eulerAngles.z;

        Rigidbody2D bullet = (Rigidbody2D) Instantiate(bulletTemplate, start, Quaternion.identity);
        bullet.velocity = new Vector2(shootSpeed * Mathf.Cos(angle * Mathf.Deg2Rad), shootSpeed * Mathf.Sin(angle * Mathf.Deg2Rad));
    }

    private void OnGUI()
    {

    }
}
