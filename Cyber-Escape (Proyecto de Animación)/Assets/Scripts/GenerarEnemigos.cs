using UnityEngine;
using System.Collections;

public class GenerarEnemigos : MonoBehaviour {

	public GameObject[] listaEnemigos;
	public GameObject objetoLimite;
	public float[] carriles = {-1.1f, 0f, 1.1f};
	public float tiempoMin = 50f;
	public float tiempoMax = 300f;

	// Use this for initialization
	void Start () {
		Generar ();
	}
	
	// Update is called once per frame
	void Update () {}

	public void Generar(){
		float posicionRandomZ = Random.Range (0, 50);
		float posicionX = Random.Range (0, 3);
		print (carriles[(int) posicionX]);
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + posicionRandomZ);

		if (transform.position.z < objetoLimite.gameObject.transform.position.z) {
			print (transform.rotation);
			Instantiate (listaEnemigos [Random.Range (0, listaEnemigos.Length)], transform.position, Quaternion.AngleAxis(90, new Vector3(1,0,0)) );
			Invoke ("Generar", Random.Range (tiempoMin, tiempoMax));
		} else {
			Destroy (this.gameObject);
		}

	}
}
