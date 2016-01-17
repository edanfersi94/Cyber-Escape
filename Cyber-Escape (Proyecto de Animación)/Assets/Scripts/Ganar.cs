using UnityEngine;
using System.Collections;

public class Ganar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(WaitAndShoot());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator WaitAndShoot()
	{
		yield return new WaitForSeconds(4f);
		Application.LoadLevel(0);

	}
}
