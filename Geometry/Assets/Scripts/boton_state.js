#pragma strict

var onMouseEnterSprite 	: Sprite;
var onMouseExitSprite	: Sprite;
var onMouseDownSprite	: Sprite;
var onMouseDragSprite	: Sprite;


function Start () {

}

function Update () {
	
}

function OnMouseUp()
{
	GetComponent(SpriteRenderer).sprite = onMouseEnterSprite;
}

function OnMouseDown()
{
	GetComponent(SpriteRenderer).sprite = onMouseDownSprite;
	//cambio de escena...
}

function OnMouseDrag()
{
	GetComponent(SpriteRenderer).sprite = onMouseDragSprite;
}

function OnMouseEnter()
{
	GetComponent(SpriteRenderer).sprite = onMouseEnterSprite;
}

function OnMouseExit()
{	
	GetComponent(SpriteRenderer).sprite = onMouseExitSprite;
}