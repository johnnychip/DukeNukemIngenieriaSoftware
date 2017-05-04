using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour {

	public NavMeshAgent myAgent;

	public Transform[] path = new Transform[2];

	private int currentPoint;

	// Use this for initialization
	void Start () 
	{
		currentPoint = 0;
		myAgent.SetDestination (path [currentPoint].position);
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float distance = Vector3.SqrMagnitude (path [currentPoint].position - transform.position);
		distance *= distance;

		if (distance < 5f) {
			currentPoint++;
			currentPoint = currentPoint % path.Length;
			myAgent.SetDestination (path [currentPoint].position);
		}
	}
}
