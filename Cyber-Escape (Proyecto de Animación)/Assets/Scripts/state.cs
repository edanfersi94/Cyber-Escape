using UnityEngine;
using System.Collections;

public class state : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (0, 0, 0);
		transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
	}
}
