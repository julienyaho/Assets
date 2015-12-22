﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UiManager : MonoBehaviour {

	public Button[] buttons;
	public Text scoreText;
	bool gameOver;
	int score;


	// Use this for initialization
	void Start () {
		gameOver = false;
		score = 0;
		InvokeRepeating ("scoreUpdate", 1.0f, 0.5f);
	
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + score; 
	}

	void scoreUpdate(){
		if (gameOver == false) {
			score += 1;
		}
	}

	public void gameoverActivated(){
		gameOver = true;
		foreach (Button button in buttons){
			button.gameObject.SetActive(true);
		}
	}

	public void Play(){

		Application.LoadLevel("level 1");
	}
	
	public void Pause(){

		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		} 
		else if (Time.timeScale == 0) {
			Time.timeScale = 1;

		}

	}

	/*public void Replay (){

		Application.LoadLevel (Application.loadedLeve l);

	}*/

	public void Menu(){

		Application.LoadLevel("menu");// this is the name of the menu you created
	}


	public void Exit(){
	 
		Application.Quit ();
	}
  }


