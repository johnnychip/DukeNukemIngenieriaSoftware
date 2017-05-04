using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour {

	public GameObject prefBala;

	public Transform spawnTrans;

	public float bulletSpeed;

	private int balas;

	void Start ()
	{
		balas = 10;
	}

	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			ShootBullet ();
		}
	}

	void ShootBullet()
	{
		if (balas <= 0)
			return;
		GameObject tempBala = Instantiate (prefBala, spawnTrans.position, spawnTrans.rotation);
		tempBala.GetComponent<Rigidbody> ().AddRelativeForce (Vector3.forward * bulletSpeed, ForceMode.Impulse);
		balas--;
	}

	public int Balas {
		get {
			return balas;
		}
		set {
			balas = value;
		}
	}
}
