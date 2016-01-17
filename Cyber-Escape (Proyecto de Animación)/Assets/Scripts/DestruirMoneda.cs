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

			AudioSource audioSource = gameObject.AddComponent<AudioSource>();
			audioSource.clip = Resources.Load("Audio/soundMoneda") as AudioClip;
			audioSource.Play();

			Destroy (objeto.gameObject);
			Coin += 1;
			//print("You now have "+ Coin +" coins" );

		}
	}

	void OnGUI()
	{

		GUIStyle myStyle = new GUIStyle ();
		myStyle.fontSize = 80;

		Font myFont = (Font)Resources.Load("Fonts/HACKED", typeof(Font));
		myStyle.font = myFont;

	 	GUI.Label(new Rect(10,10, 100, 30), "Monedas = " + Coin, myStyle);
	}
}
