using UnityEngine;
using System.Collections;

public class spinner : MonoBehaviour {
	public float damping = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward * Time.deltaTime * damping);
	}
}
