using UnityEngine;
using System.Collections;

public class lifeCounter : MonoBehaviour {
	
	public GameObject triangulo1;
	public GameObject triangulo2;
	public GameObject triangulo3;
	public GameObject gameOver;
	public GameObject retry;
	public int contador;

		// Use this for initialization
		void Start () {

		contador = 0;
			
		}
		
		// Update is called once per frame
		void Update () {
		Debug.Log (contador);
		if (Input.GetKeyDown (KeyCode.E) && (contador == 0)) {
						triangulo1.SetActive (false);
						contador += 1;
				} else if (Input.GetKeyDown (KeyCode.E) && (contador == 1)) {
						triangulo2.SetActive (false);
						contador += 1;
				} else if (Input.GetKeyDown (KeyCode.E) && (contador == 2)) {
						triangulo3.SetActive (false);
						contador += 1;
						Time.timeScale = 0;
						gameOver.SetActive (true);
						retry.SetActive (true);
				} else if (Input.GetKeyDown (KeyCode.E) && (contador == 3)) {
						gameOver.SetActive 	(false);
						retry.SetActive 	(false);
						triangulo1.SetActive (true);
						triangulo2.SetActive (true);
						triangulo3.SetActive (true);
						contador = 0;
				}
		}

		public void minusLife() {

			switch (contador) {
			case 0: 
					triangulo1.SetActive (false);
					break;
			case 1: 
					triangulo2.SetActive (false);
					break;
			case 2:
					triangulo3.SetActive (false);
					gameOver.SetActive (true);
					retry.SetActive (true);
					break;
			}
			contador += 1;
		}
}
