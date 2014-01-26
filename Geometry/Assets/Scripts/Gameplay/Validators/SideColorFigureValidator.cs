using UnityEngine;
using System.Collections;

public class SideColorFigureValidator : MonoBehaviour {
	public Figure figureType;
   // public Figure figureType;
    public SpriteRenderer spriteShape;
    public TriColor triColor;

	/*public enum Figure
    {
        Circle,
        Square,
        Star
    }

    public enum TriColor
    {
        Red,
        Green,
        Blue
    }*/

	public void SwapShape () {
        switch(figureType)
        {
            case Figure.Circle:
			figureType = Figure.Cube;
                //figureType = Figure.Square;
                spriteShape.sprite = ValidatorsController.Instance.square;
			GetComponent<checkFigureCollition>().figure = GetComponent<checkFigureCollition>().figure = Figure.Cube;
                break;
		case Figure.Cube:
			figureType = Figure.Star;
                spriteShape.sprite = ValidatorsController.Instance.star;
			GetComponent<checkFigureCollition>().figure = GetComponent<checkFigureCollition>().figure = Figure.Star;
                break;
            case Figure.Star:
                figureType = Figure.Circle;
                spriteShape.sprite = ValidatorsController.Instance.circle;
				GetComponent<checkFigureCollition>().figure = GetComponent<checkFigureCollition>().figure = Figure.Circle;
				
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
