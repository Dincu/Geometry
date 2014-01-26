#pragma strict

var retryOn 	: Sprite;

function Start () {

}

function Update () {

}

function OnMouseDown () {
	GetComponent(SpriteRenderer).sprite = retryOn;
	Application.LoadLevel('MainScene(1)');
}