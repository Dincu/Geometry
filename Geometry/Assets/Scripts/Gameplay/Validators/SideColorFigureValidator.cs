using UnityEngine;
using System.Collections;

public class SideColorFigureValidator : MonoBehaviour {
    public Figure figureType;
    public SpriteRenderer spriteShape;
    public TriColor triColor;

    public enum Figure
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
    }

	public void SwapShape () {
        switch(figureType)
        {
            case Figure.Circle:
                figureType = Figure.Square;
                spriteShape.sprite = ValidatorsController.Instance.square;
                break;
            case Figure.Square:
                figureType = Figure.Star;
                spriteShape.sprite = ValidatorsController.Instance.star;
                break;
            case Figure.Star:
                figureType = Figure.Circle;
                spriteShape.sprite = ValidatorsController.Instance.circle;
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
