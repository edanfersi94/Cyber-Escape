using UnityEngine;
using System.Collections;

public class Jugador : MonoBehaviour {

	// Variables públicas.
	public Animator animacion;  // Manejador de las animaciones.
	public bool inicioAnimacion = false;
	public bool finalizoAnimacion = true;
	public Rigidbody rgBody;
	public GameObject jugador;

	// Variables privadas.
	private bool enElSuelo;     // Indica si el personaje no está enElSuelondo. 
	private float velocidad = 100f;

	// Descripción:
	// 		Función que me permite incializar variables.
	void Start () {
		animacion = jugador.GetComponent<Animator> ();
		rgBody = jugador.GetComponent<Rigidbody> ();
		enElSuelo = true;
	}
	
	// Descripción:
	// 		Función que se ejecutará cada frame.
	void Update () {

		//if (animacion.IsInTransition (0) &&
		//	animacion.GetNextAnimatorStateInfo(0).IsName("Corriendo")) {
		//	enElSuelo = true;
		//	transform.parent.position = transform.position;
		//	transform.localPosition = Vector3.zero;
		//}
		
		//if ( Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) ) {
		//	
		//} 

		if (Input.GetKeyDown(KeyCode.Space) && enElSuelo){ 
			enElSuelo = false;
			inicioAnimacion = true;
			finalizoAnimacion = false;
			animacion.Play ("Saltando", -1, 0f); 
		}

		// El personaje comienza a moverse.
		float movimiento = velocidad * Time.deltaTime;
		rgBody.velocity = new Vector3 (0f, 0f, movimiento);
		//transform.position = transform.parent.position;
	}

	public void finalizoAnimacionSalto(){
		print (transform.position.z);
		enElSuelo = true;
		finalizoAnimacion = true;
	}

	void LateUpdate(){
		
		if (inicioAnimacion && finalizoAnimacion) {
			//transform.parent.position = transform.position;
			//transform.localPosition = Vector3.zero;
			animacion.Play ("Corriendo", -1, 0f); 
		}
	}
}
