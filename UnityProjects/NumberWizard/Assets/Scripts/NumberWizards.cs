using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head, but don't tell me!");

		print ("Is the number higher or lower than 500?");
		print ("Up = Higher, Down = Lower, Return = Equal");
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			print ("Up arrow pressed!");
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			print ("Down arrow pressed!");
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!");
		}

	}

}
