﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    PlayerStats p;
    public GameObject followTarget;
    private Vector3 targetPos;
    public float moveSpeed;

	// Use this for initialization
	void Start () {
        p = FindObjectOfType<PlayerStats>();
        followTarget = PlayerManager.instance.player;
        moveSpeed = p.baseSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
	}
}
