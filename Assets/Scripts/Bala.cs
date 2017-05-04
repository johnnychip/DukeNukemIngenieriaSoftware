using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "enemigo") {

			Destroy (other.gameObject);
			Destroy (gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
