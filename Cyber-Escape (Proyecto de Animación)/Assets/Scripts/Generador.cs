using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {

	// Variables Públicas.
	public GameObject[] listaObjetos; 					// Objetos a instanciar.
	public GameObject objetoLimite;						// Objeto que indicará hasta donde aparecerán los objetos. 
	public float[] carriles = {-1.1f, 0f, 1.1f};      	// Ubicación de los carriles.

	// Variables para el manejo de la instanciaciones.
	public float tiempoMin = 50f;
	public float tiempoMax = 300f;

	public int anguloX;

	// Use this for initialization
	void Start () {
		Generar ();
	}

	// Update is called once per frame
	void Update () {}

	public void Generar(){
		float posicionRandomZ = Random.Range (0, 50);
		float posicionRandomX = Random.Range (0, 3);
		print (carriles[(int) posicionRandomX]);

		// Nueva posición donde se hará la instanciación.
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + posicionRandomZ);

		if (transform.position.z < objetoLimite.gameObject.transform.position.z) {
			Instantiate (listaObjetos [Random.Range (0, listaObjetos.Length)], transform.position, Quaternion.AngleAxis(anguloX, new Vector3(1,0,0)) );
			Invoke ("Generar", Random.Range (tiempoMin, tiempoMax));
		} else {
			Destroy (this.gameObject);
		}

	}
}

