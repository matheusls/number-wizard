using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max = 1000;
	int min = 1;
	int guess = 500;
	
	void GameStart () {
		max = max + 1;
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head but don't tell me!");
		print ("The highest number you can pick is " + max);
		print ("And the lowest number you can pick is " + min);
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equal.");
	}
	
	void GameRestart () {
		max = 1000;
		min = 1;
		guess = 500;
		
		print ("=========================");
		GameStart();
	}

	void NextGuess () {
		guess = (max + min) / 2;
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equal.");
	}

	// Use this for initialization
	void Start () {
		GameStart();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!");
			GameRestart();
		}
	}
}
