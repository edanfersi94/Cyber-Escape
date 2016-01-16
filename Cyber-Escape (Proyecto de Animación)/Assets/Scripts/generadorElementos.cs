using UnityEngine;
using System.Collections;

public class generadorElementos : MonoBehaviour {

    //Variables públicas.
    public GameObject objetoG;  // Elemento que se desea generar.
	public GameObject limiteG;  // Objeto que se utilizará para ser la posición final de generación.
	public bool variosCarriles; // Booleano que permitirá indicar si el objeto se desea generar en varios
								// carriles.
	public bool esMoneda;       // Booleano que indica si se va a generar una moneda
	public float[] carriles = {-1.1f, 0f, 1.1f};  // Ubicación de los carriles.
	public int anguloX;         // Angulo en que se generará los objetos.
	public int distanciaObst;   // Distancia que se tendrán entre cada objeto. 

	private int nObjetos;       // Cantidad de objetos a generar.
	private int ultimoCarril;   // Indexx del último carril elegido.

	// Descripción:
	// 		Función que me permite incializar variables.
	void Start () {
		if (variosCarriles) {
			ultimoCarril = -1;
			if (esMoneda) {
				nObjetos = Random.Range (60, 70);
				distanciaObst = 310 / nObjetos; // Se toma 320 porque la pista tiene este largo.
			} else {
				nObjetos = Random.Range (30, 50);
				distanciaObst = 310 / nObjetos; // Se toma 320 porque la pista tiene este largo.
			}
		} else {
			nObjetos = Random.Range (10, 15);
			distanciaObst = 320 / nObjetos; // Se toma 320 porque la pista tiene este largo.
		}

		Generar ();
	}
	
	// Descripción:
	// 		Función que se ejecutará cada frame.
	void Update () {
	
	}

	// Descripción:
	// 		Función que se ejecutará cuando exista una colisión.
	// Parámetros:
	// 		* Collision objeto: elemento con el que se choca.
	void Generar(){
		if (transform.position.z < limiteG.gameObject.transform.position.z) {
			if (variosCarriles) {
				int carrilElegido = Random.Range (0, 3);
				if (!esMoneda) {

					if (carrilElegido == ultimoCarril) {
						while (carrilElegido == ultimoCarril) {
							carrilElegido = Random.Range (0, 3);
						}
					}
				}

				ultimoCarril = carrilElegido;
				transform.position = new Vector3 (carriles[carrilElegido], transform.position.y, transform.position.z + distanciaObst);
				Instantiate (objetoG, transform.position, Quaternion.AngleAxis (anguloX, new Vector3 (1, 0, 0)));
				Invoke ("Generar", 0f);
			} else {
				transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + distanciaObst);
				Instantiate (objetoG, transform.position, Quaternion.AngleAxis (anguloX, new Vector3 (1, 0, 0)));
				Invoke ("Generar", 0f);
			}
		} else {
			Destroy (this.gameObject);
		}

	}
}
