using UnityEngine;
using System.Collections;

public class EnemigoController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision objeto){

		if (objeto.gameObject.tag == "Player") {
			AudioSource audioSource = gameObject.AddComponent<AudioSource>();
			audioSource.clip = Resources.Load("Audio/muerte") as AudioClip;
			audioSource.Play();
			Destroy (objeto.gameObject);
		}
	}
}
