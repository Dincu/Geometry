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
    }

    public enum playerPosition
    {
        LEFT = -20,
        CENTER = 0,
        RIGTH = 20
    }
	
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.A))
		{
            if (currentStance == playerPosition.RIGTH)
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

		}

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * damping);
	}
	
	void FixedUpdate()
	{

	}
}
