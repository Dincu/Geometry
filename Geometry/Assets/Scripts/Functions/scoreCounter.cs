using UnityEngine;
using System.Collections;

public class scoreCounter : MonoBehaviour {

	public int sCounter;

	// Use this for initialization
	void Start () {
		sCounter = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Q)){
			sCounter += 1;
			guiText.text = "Score: " +sCounter;
		}
	}
}
