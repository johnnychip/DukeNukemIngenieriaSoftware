using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter(Collision other)
	{
		

		if (other.gameObject.tag == "enemy") {

			GameManager.Instance.NotifyHit ();

			Destroy (other.gameObject);
			Destroy (gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
