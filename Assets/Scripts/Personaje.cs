﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour {

	public Disparar miDisparar;

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter(Collision other)
	{
		Debug.Log ("Happend");
		if (other.gameObject.tag == "ammo") {
		
			miDisparar.Balas += 5;
		
		}

	}

	// Update is called once per frame
	void Update () {
		
	}
}
