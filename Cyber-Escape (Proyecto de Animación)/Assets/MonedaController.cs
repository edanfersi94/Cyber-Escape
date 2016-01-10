using UnityEngine;
using System.Collections;

public class MonedaController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision node)
	{
		print ("Hola");
		if(node.gameObject.tag == "Player")
		{
			Destroy(this.gameObject);
			//global.score++; //optional, if you have global with score
		}
	}

}
