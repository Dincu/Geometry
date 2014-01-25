using UnityEngine;
using System.Collections;



public class TriangleRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (Input.GetKeyDown (KeyCode.S)) {
			animation.Play("yellow_to_blue");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
