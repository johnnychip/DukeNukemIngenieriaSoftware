using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemigoDron : MonoBehaviour {

	public NavMeshAgent agenr;

	public Transform target;

	// Use this for initialization
	void Start () {
		agenr.SetDestination (target.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
