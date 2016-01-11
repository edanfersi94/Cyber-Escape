using UnityEngine;
using System.Collections;

public class DestruirMoneda : MonoBehaviour {
	public int Coin=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision objeto){
		
		if (objeto.gameObject.tag == "Moneda") {
			
			Destroy (objeto.gameObject);
			Coin += 1;
			print("You now have "+ Coin +" coins" );

		}
	}

	void OnGUI()
	{
		GUILayout.Label( "Score = " + Coin);
	}
}
