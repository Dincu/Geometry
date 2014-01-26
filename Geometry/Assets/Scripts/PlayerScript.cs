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
		LEFT = -4,
        CENTER = 0,
        RIGHT = 4
    }
	
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.A))
		{
			if (currentStance == playerPosition.RIGHT)
            {
                currentStance = playerPosition.CENTER;
                targetPosition = originPosition;
            }
            else if (currentStance == playerPosition.CENTER)
            {
                currentStance = playerPosition.LEFT;
                targetPosition = originPosition + new Vector3((float)playerPosition.LEFT, 0);
            }
		}

		if(Input.GetKeyDown(KeyCode.D))
		{
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

        Vector3 tempPosition = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * damping);
		transform.position = new Vector3(tempPosition.x, originPosition.y, originPosition.z);
	}
	
	void FixedUpdate()
	{

	}
}
