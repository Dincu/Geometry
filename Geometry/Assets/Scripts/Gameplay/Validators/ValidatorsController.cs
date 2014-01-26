using UnityEngine;
using System.Collections;

public class ValidatorsController : MonoBehaviour {
	// Update is called once per frame
    public Sprite square;
    public Sprite circle;
    public Sprite star;

    public static ValidatorsController Instance;

    void Start()
    {
        Instance = this;
    }

	void Update () {
       
	}

	public void swapFigures() {
		SideColorFigureValidator[] validators = GetComponentsInChildren<SideColorFigureValidator>();
		
		for (int i = 0; i < validators.Length; i++)
			validators[i].SwapShape();
	}
}
