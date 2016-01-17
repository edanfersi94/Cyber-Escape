using UnityEngine;
using System.Collections;

public class JugadorController : MonoBehaviour {

	// Variables Privadas.
	private float velocidad = 350f;
	private Rigidbody rgBody;
	private float actualPosition;    // Carril en donde está ubicado el jugador. (-1.1 -> Carril 1, 0 -> Carril 2, 1.1 -> Carril 3)
	private float movLateral; // Distancia máxima que se puede mover a los lados

	// Descripción:
	// 		Función que me permite incializar variables.
	void Start () {	
		rgBody = GetComponent<Rigidbody> ();

		movLateral =  1.1f;
		actualPosition = 0f;
	
	}
	
	// Descripción:
	// 		Función que se ejecutará cada frame.
	void Update () {
		
		// El personaje comienza a moverse.
		float movimiento = velocidad * Time.deltaTime;
		rgBody.velocity = new Vector3 (0f, 0f, movimiento);

		if (Input.GetKeyDown (KeyCode.LeftArrow) && actualPosition > -movLateral) {
			actualPosition -= movLateral;
			transform.position = new Vector3 (actualPosition, transform.position.y, transform.position.z);
		} else if (Input.GetKeyDown (KeyCode.RightArrow)  && actualPosition < movLateral) {
			actualPosition += movLateral;
			transform.position = new Vector3 (actualPosition, transform.position.y, transform.position.z);
		}
	}
}
