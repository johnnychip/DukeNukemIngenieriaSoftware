using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour {

	public Transform[] spawnPoints;

	public GameObject[] enemyPref = new GameObject[2];

	public Transform player;

	// Use this for initialization
	void Start () {
		
		for (int i = 0; i < Random.Range (1, 5); i++) {
			int tempRandom = Random.Range (0, spawnPoints.Length);
			int tempRandom2 = Random.Range (0, 2);
			GameObject tempObj = Instantiate (enemyPref[tempRandom2], spawnPoints [tempRandom].position, spawnPoints [tempRandom].rotation);
			if (tempRandom2 == 0) {
			
				tempObj.GetComponent<EnemigoDron> ().target = player;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
