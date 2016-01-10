using UnityEngine;
using System.Collections;

public class ManejoAnimaciones : MonoBehaviour {

	// Variables Públicas.
	public bool inicioAnimacion = false;
	public bool finalizoAnimacion = true;
	public bool enElSuelo = true;

	// Variables Privadas.
	private Animator ctrlAnimacion;

	// Descripción:
	// 		Función que me permite incializar variables.
	void Start () {
		ctrlAnimacion = GetComponent<Animator> ();
	}
	
	// Descripción:
	// 		Función que se ejecutará cada frame.
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && enElSuelo) {
			enElSuelo = false;

			inicioAnimacion = true;
			finalizoAnimacion = false;

			ctrlAnimacion.Play ("Saltando", -1, 0f);
		}
	}

	public void finalizoAnimacionSalto(){
		finalizoAnimacion = true;
	}

	void LateUpdate(){
		if (inicioAnimacion && finalizoAnimacion) {
			enElSuelo = true;
			inicioAnimacion = false;

			transform.parent.position = transform.position;
			transform.localPosition = Vector3.zero;
		}
	}
}
