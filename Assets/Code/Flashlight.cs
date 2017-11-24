﻿/*
---------------------------------------

Rafi Emilio Alam 
for the Game Off game jam

---------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {

	AntiVirus av;
	[SerializeField] GameObject spot;

	void Start () {
		av = transform.parent.GetComponent<AntiVirus>();
	}

	void Update () {
		if (!av.player && spot.activeSelf) {
			spot.SetActive(false);
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			av.player = other.gameObject;
			LevelManager.reset = true;
			spot.SetActive(true);
		}
	}
}
