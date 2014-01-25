#pragma strict

var backgroundTexture:Texture;
var style : GUIStyle;

function Start () {

}

function Update () {

}

function OnGUI () {
	
	GUI.skin.button = style;
	//GUI.DrawTexture ( new Rect (0,0, Screen.width, Screen.height), backgroundTexture);
	// Make a background box

	// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
	if (GUI.Button (Rect ((Screen.width/2)-125,(Screen.height/2)-40,250,80), "¡JUGAR!")) {
		print('start the game');
	}

	// Make the second button.
	if (GUI.Button (Rect ((Screen.width/2)-93.75,(Screen.height/2)+60,187.5f,60), "Salir...")) {
		print('Salir...');
	}
	
	if (GUI.Button (Rect ((Screen.width/2)-100, Screen.height-75, 200, 50), "The team")) {
		print('Creditos...');
	}
}