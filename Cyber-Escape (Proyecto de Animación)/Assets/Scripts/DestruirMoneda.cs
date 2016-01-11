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
		GUIStyle myStyle = new GUIStyle ();
		myStyle.fontSize = 50;

		Font myFont = (Font)Resources.Load("Fonts/HACKED", typeof(Font));
		myStyle.font = myFont;

		//myStyle.normal.textColor = Color.red;
		//myStyle.hover.textColor = Color.red;
		
	 	GUI.Label(new Rect(10,10, 100, 30), "Score = " + Coin, myStyle);
	}
}
