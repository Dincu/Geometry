using UnityEngine;
using System.Collections;

public class checkFigureCollition : MonoBehaviour {

	public TriColor color;
	public Figure figure;
	public scoreCounter Whatever, Whatever2;
	public lifeCounter lifeManager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		Figure otherFigure = other.GetComponent<figureType>().figure;
		TriColor otherColor = other.GetComponent<figureType>().triColor;

		if ((figure == otherFigure) && (color == otherColor)) {
			//Add Score

			Whatever.addScore();
			Whatever2.addScore();
			Debug.Log("Score");
			ValidatorsController.Instance.swapFigures();
		}
		else {
			//Do Damage
			lifeManager.minusLife();
			Debug.Log("Damage");

		}

		Destroy(other.gameObject);
	}
}
