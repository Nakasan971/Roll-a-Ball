using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 10;

	void FixedUpdate () {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rigidbody = GetComponent<Rigidbody>();

        rigidbody.AddForce(x * speed,0,z * speed);

        if (Input.GetKey(KeyCode.Space)){
            rigidbody.AddForce(0, speed * 2, 0);
        }else{
            rigidbody.AddForce(0, -speed * 2, 0);
        }
	}
}
