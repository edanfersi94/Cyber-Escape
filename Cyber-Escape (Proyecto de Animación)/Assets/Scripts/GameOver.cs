using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = Resources.Load("Audio/muerte") as AudioClip;
		audioSource.Play();

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

	void OnGUI()
	{

		GUIStyle myStyle = new GUIStyle ();
		myStyle.fontSize = 40;

		Font myFont = (Font)Resources.Load("Fonts/HACKED", typeof(Font));
		myStyle.font = myFont;

		myStyle.normal.textColor = Color.white;
		myStyle.hover.textColor = Color.white;

		GUI.Label(new Rect(600,450, 50, 30), "Monedas : " + DestruirMoneda.Coin, myStyle);
	}
}
