using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {

	public GUIText gameOverText;

	private bool gameOver;

	void Start () {
		gameOver = false;
		gameOverText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GameOver(){
		gameOverText.text = "Game Over";
		gameOver = true;
	}
}
