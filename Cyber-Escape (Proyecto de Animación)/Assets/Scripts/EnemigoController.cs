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
			Destroy (objeto.gameObject);
		}
	}
}
