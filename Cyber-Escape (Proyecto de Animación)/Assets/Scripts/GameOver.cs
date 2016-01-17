﻿using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = Resources.Load("Audio/muerte") as AudioClip;
		audioSource.Play();

		StartCoroutine(WaitAndShoot());

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator WaitAndShoot()
	{
		yield return new WaitForSeconds(4f);
		Application.LoadLevel(0);

	}
}
