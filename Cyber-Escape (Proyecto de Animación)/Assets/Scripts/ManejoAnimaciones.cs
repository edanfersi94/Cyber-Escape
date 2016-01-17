using UnityEngine;
using System.Collections;

public class ManejoAnimaciones : MonoBehaviour {

	// Variables Públicas.
	public bool inicioAnimacion = false;
	public bool finalizoAnimacion = true;
	public bool enElSuelo = true;
	public BoxCollider bxCollider;
	// Variables Privadas.
	private Animator ctrlAnimacion;

	// Descripción:
	// 		Función que me permite incializar variables.
	void Start () {
		ctrlAnimacion = GetComponent<Animator> ();
		bxCollider = GetComponent<BoxCollider> ();

		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = Resources.Load("Audio/alerta") as AudioClip;
		audioSource.Play();
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

	public void UpBoxCollider(){
		bxCollider.center = new Vector3 (bxCollider.center.x, 2f, bxCollider.center.z);
	}

	public void DownBoxCollider(){
		bxCollider.center = new Vector3 (bxCollider.center.x, 0.95f, bxCollider.center.z);
	}

	void LateUpdate(){
		if (inicioAnimacion && finalizoAnimacion) {
			enElSuelo = true;
			inicioAnimacion = false;
		}
	}
}
