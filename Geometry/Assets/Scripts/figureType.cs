using UnityEngine;
using System.Collections;

public enum TriColor
{
	Red,
	Green,
	Blue
}

public enum Figure
{
	Circle,
	Cube,
	Star
}

public class figureType : MonoBehaviour {

	public TriColor triColor;
	public Figure figure;
	public Material[] materials = new Material[3];

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
