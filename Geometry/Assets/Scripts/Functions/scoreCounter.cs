using UnityEngine;
using System.Collections;

public class scoreCounter : MonoBehaviour {
	// Score Counter
	public int sCounter;

	// Use this for initialization
	void Start () {
		// Start counter on 0
		sCounter = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void addScore()
	{
		// add 1 to the counter
		sCounter += 1;
		// print counter on the gui text
		guiText.text = "" +sCounter;
		Debug.Log(sCounter);
	}
}
