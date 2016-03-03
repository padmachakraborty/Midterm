﻿using UnityEngine;
using System.Collections;

public class RoadController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public float speed=3f;

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();
		this._Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		 Vector2 currentPosition = gameObject.GetComponent<Transform> ().position;
		currentPosition.y -= speed;
		gameObject.GetComponent<Transform> ().position = currentPosition;

 
		if (currentPosition.y <= -480) {
			this._Reset();
		}
	}

	private void _Reset() {
		Vector2 resetPosition = new Vector2 (0.0f, 480f);
		gameObject.GetComponent<Transform> ().position = resetPosition;
	}
}
