﻿using UnityEngine;
using System.Collections;

public class MusicController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (gameObject.GetComponent<AudioSource> ()==null) {
			Destroy(gameObject);		
		}
	}
}