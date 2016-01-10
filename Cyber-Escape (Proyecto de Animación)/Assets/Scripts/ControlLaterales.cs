using UnityEngine;
using System.Collections;

public class ControlLaterales : MonoBehaviour {

	// Variables Privadas.
	private float actualPosition;    // Carril en donde está ubicado el jugador. (-1.1 -> Carril 1, 0 -> Carril 2, 1.1 -> Carril 3)
	private float movLateral; // Distancia máxima que se puede mover a los lados

	// Descripción:
	// 		Función que me permite incializar variables.
	void Start () {
		movLateral =  1.1f;
		actualPosition = 0f;
	}
	
	// Descripción:
	// 		Función que se ejecutará cada frame.
	void Update () {
		//if (Input.GetKeyDown (KeyCode.LeftArrow)) {
		//	actualPosition -= movLateral;
		//	transform.position = new Vector3 (actualPosition, transform.position.y, transform.position.z);
		//} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
		//	actualPosition += movLateral;
		//	transform.position = new Vector3 (actualPosition, transform.position.y, transform.position.z);
		//}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			actualPosition -= movLateral;
			transform.position = new Vector3 (actualPosition, transform.position.y, transform.position.z);
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			actualPosition += movLateral;
			transform.position = new Vector3 (actualPosition, transform.position.y, transform.position.z);
		}
	}
}
