using UnityEngine;
using System.Collections;

public class checkFigureCollition : MonoBehaviour {

	public TriColor color;
	public Figure figure;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		Figure otherFigure = other.GetComponent<figureType>().figure;
		TriColor otherColor = other.GetComponent<figureType>().triColor;
		Debug.Log("Trigger");
		if ((figure == otherFigure) && (color == otherColor)) {
			//Add Score
//			scoreCounter();
		}
		else {
			//Do Damage
//			lifeCounter();
		}

		Destroy(other.gameObject);
	}
}
