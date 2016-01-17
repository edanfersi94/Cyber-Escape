using UnityEngine;
using System.Collections;

public class ControladorColisionesMonedas : MonoBehaviour {

	// Variable públicas.
	public float[] carriles = {-1.1f, 1.1f};
	public int posicionElegida;
	public int Coin=0;

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
	void OnCollisionEnter(Collision objeto){
		if (objeto.gameObject.tag == "Player") {

			AudioSource audioSource = gameObject.AddComponent<AudioSource>();
			audioSource.clip = Resources.Load("Audio/soundMoneda") as AudioClip;
			audioSource.Play();


			Destroy (this.gameObject);
			Coin += 1;
		} else if (objeto.gameObject.tag == "EnemigoSalto") {
			
			this.gameObject.transform.position = new Vector3 (this.transform.position.x, 10f, this.transform.position.z);	
		} else if (objeto.gameObject.tag == "EnemigoEsquivar") {
			if (this.transform.position.x == 1.1f || this.transform.position.x == -1.1f) {
				this.transform.position = new Vector3 (0f, this.transform.position.y, this.transform.position.z);
			} else {
				posicionElegida = Random.Range (0, 2);
				this.transform.position = new Vector3 (carriles[posicionElegida], this.transform.position.y, this.transform.position.z);
			}
		} 
	}

	void OnGUI()
	{
		GUIStyle myStyle = new GUIStyle ();
		myStyle.fontSize = 50;

		Font myFont = (Font)Resources.Load("Fonts/HACKED", typeof(Font));
		myStyle.font = myFont;

		//myStyle.normal.textColor = Color.red;
		//myStyle.hover.textColor = Color.red;

		GUI.Label(new Rect(10,10, 100, 30), "Monedas = " + Coin, myStyle);
	}
}
