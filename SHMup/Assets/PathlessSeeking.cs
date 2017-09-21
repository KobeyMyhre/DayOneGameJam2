﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathlessSeeking : MonoBehaviour {


    public GameObject target;
    public float speed = 1;
    Vector3 velocity;
    Rigidbody rb;


    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	

    public void DoSeek()
    {
        Vector3 dir = (target.transform.position - transform.position).normalized;
        Vector3 desiredVelocity = dir * speed;


        Vector3 steeringForce = desiredVelocity - rb.velocity;
        rb.AddForce(steeringForce);
        Vector3 head = rb.velocity;
        head.y = 0;
        transform.LookAt(transform.position + head, Vector3.up);
    }

	// Update is called once per frame
	void Update ()
    {
        DoSeek();
	}
}
