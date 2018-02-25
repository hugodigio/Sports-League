using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Characterdeplacement : MonoBehaviour {

    private CharacterController controller;
    private Vector3 dDirection;
    private float deltaTime;
    private float rotationspeed = 3.0f;
    float speed = 3.0f;
    float gravity = 0.5f;

    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        deltaTime = Time.deltaTime;
        dDirection = new Vector3(Input.GetAxis("Vertical") * speed, -gravity, -Input.GetAxis("Horizontal") * speed);
        dDirection = transform.TransformDirection(dDirection);
        controller.Move(dDirection * deltaTime);
	}
}
