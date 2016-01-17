using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = Resources.Load("Audio/muerte") as AudioClip;
		audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
