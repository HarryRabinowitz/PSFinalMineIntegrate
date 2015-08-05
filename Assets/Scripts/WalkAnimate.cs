﻿using UnityEngine;
using System.Collections;

public class WalkAnimate : MonoBehaviour {

	public Animation anim;
	// Use this for initialization
	void Start () {
	
		anim = GetComponent<Animation>();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.S)) {

			anim.Play();
		}
	
	}
}
