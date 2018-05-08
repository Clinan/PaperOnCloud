using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freeze : MonoBehaviour {

    public Rigidbody r;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        r = GetComponent<Rigidbody>();
        r.velocity = new Vector3(0, 0, 0);
    }
}
