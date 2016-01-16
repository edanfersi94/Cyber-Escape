using UnityEngine;
using System.Collections;

public class ControladorColisionesMoneda : MonoBehaviour {

	// Variable públicas.
	public float[] carriles = {-1.1f, 1.1f};
	public int posicionElegida;

	// Descripción:
	// 		Función que me permite incializar variables.
	void Start () {
	
	}
	
	// Descripción:
	// 		Función que se ejecutará cada frame.
	void Update () {
	
	}

	// Descripción:
	// 		Función que se ejecutará cuando exista una colisión.
	// Parámetros:
	// 		* Collision objeto: elemento con el que se choca.
	void onCollisionEnter(Collision objeto){
		if (objeto.gameObject.tag == "Player") {
			Destroy (this.gameObject);
		} else if (objeto.gameObject.tag == "EnemigoSalto") {
			this.gameObject.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y + 1.5f, this.transform.position.z);	
		} else if (objeto.gameObject.tag == "EnemigoEsquivar") {
			if (this.transform.position.x == 1.1f || this.transform.position.x == -1.1f) {
				this.transform.position = new Vector3 (0f, this.transform.position.y, this.transform.position.z);
			} else {
				posicionElegida = Random.Range (0, 2);
				this.transform.position = new Vector3 (carriles[posicionElegida], this.transform.position.y, this.transform.position.z);
			}
		} 
	}
}
