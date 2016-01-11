using UnityEngine;
using System.Collections;

public class DetruirEnemigo : MonoBehaviour {

	// Variables Privadas.
	private float velocidad = 350f;
	private Rigidbody rgBody;

	// Descripción:
	// 		Función que me permite incializar variables.
	void Start () {
		rgBody = GetComponent<Rigidbody> ();
	}
	
	// Descripción:
	// 		Función que se ejecutará cada frame.
	void Update () {
		
		float movimiento = velocidad * Time.deltaTime;
		rgBody.velocity = new Vector3 (0f, 0f, movimiento);

	}

	void OnCollisionEnter(Collision objeto){
		if (objeto.gameObject.tag == "Enemigo")  {
			Destroy (objeto.gameObject);
		}
	}
}
