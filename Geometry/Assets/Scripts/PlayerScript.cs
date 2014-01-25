using UnityEngine;
using System.Collections;
/// <summary>
/// Player controller and behavior
/// </summary>
public class PlayerScript : MonoBehaviour
{

	
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.A))
		{
			animation.Play("move_left");
		}

		if(Input.GetKeyDown(KeyCode.D))
		{
			animation.Play("move_right");
		}
	}
	
	void FixedUpdate()
	{

	}
}
