using UnityEngine;
using System.Collections;

public class TerminarJuego : MonoBehaviour {

	// Descripción:
	// 		Función que me permite incializar variables.
	void Start () {}
	
	// Descripción:
	// 		Función que se ejecutará cada frame.
	void Update () {}

	void OnCollisionEnter(Collision objeto){
		if (objeto.gameObject.tag == "Enemigo") {
			Destroy (objeto.gameObject);
		}
	}
}
