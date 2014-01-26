using UnityEngine;
using System.Collections;
/// <summary>
/// Player controller and behavior
/// </summary>
public class PlayerScript : MonoBehaviour
{
    public float step = 30;
	public playerPosition currentStance = playerPosition.CENTER;
    public float damping;
    private Vector3 originPosition;
    private Vector3 targetPosition;

    public void Start()
    {
        originPosition = transform.position;
		targetPosition = originPosition;
    }

    public enum playerPosition
    {
		LEFT = -2,
        CENTER = 0,
        RIGHT = 2
    }
	
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.A))
		{
			Debug.Log("button A");
			if (currentStance == playerPosition.RIGHT)
            {
				Debug.Log("left to center");
                currentStance = playerPosition.CENTER;
                targetPosition = originPosition;
            }
            else if (currentStance == playerPosition.CENTER)
            {
				Debug.Log("center to right");
                currentStance = playerPosition.LEFT;
                targetPosition = originPosition + new Vector3((float)playerPosition.LEFT, 0);
            }
		}

		if(Input.GetKeyDown(KeyCode.D))
		{
			Debug.Log("button B");
			if (currentStance == playerPosition.LEFT) 
			{
				currentStance = playerPosition.CENTER;
				targetPosition = originPosition;
			}
			else if (currentStance == playerPosition.CENTER) 
			{
				currentStance = playerPosition.RIGHT;
				targetPosition = originPosition + new Vector3((float)playerPosition.RIGHT, 0);
			}

		}

		Debug.Log("movement");
        Vector3 tempPosition = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * damping);
		transform.position = new Vector3(tempPosition.x, originPosition.y, originPosition.z);
	}
	
	void FixedUpdate()
	{

	}
}
