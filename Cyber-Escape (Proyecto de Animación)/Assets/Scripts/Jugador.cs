using UnityEngine;
using System.Collections;

public class Jugador : MonoBehaviour {

	// Variables públicas.
	public Animator animacion;  // Manejador de las animaciones.
	public Rigidbody rgBody;

	// Variables privadas.
	private bool enElSuelo;     // Indica si el personaje no está saltando. 
	private float velocidad = 100f;

	// Descripción:
	// 		Función que me permite incializar variables.
	void Start () {
		animacion = GetComponent<Animator> ();
		rgBody = GetComponent<Rigidbody> ();
		enElSuelo = true;
	}
	
	// Descripción:
	// 		Función que se ejecutará cada frame.
	void Update () {

		
		//if ( Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) ) {
		//	animacion.Play ("Corriendo", -1, 0f);
		//} 

		//if (Input.GetKeyDown(KeyCode.Space) && enElSuelo){ enElSuelo = false; }
	
		//animacion.SetBool (enElSuelo);

		// El personaje comienza a moverse.
		float movimiento = velocidad * Time.deltaTime;
		rgBody.velocity = new Vector3 (0f, 0f, movimiento);
	}
}
