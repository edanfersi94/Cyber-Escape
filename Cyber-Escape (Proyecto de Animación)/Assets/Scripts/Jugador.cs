using UnityEngine;
using System.Collections;

public class Jugador : MonoBehaviour {

	// Variables públicas.
	public Animator animacion;  // Manejador de las animaciones.

	// Descripción:
	// 		Función que me permite incializar variables.
	void Start () {
		animacion = GetComponent<Animator> (); 
	}
	
	// Descripción:
	// 		Función que se ejecutará cada frame.
	void Update () {

		
		if ( Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) ) {
			animacion.Play ("Corriendo", -1, 0f);

		} else if (Input.GetKeyDown(KeyCode.Space) ){
			animacion.Play ("Saltando", -1, 0f);
		}
	}
}
