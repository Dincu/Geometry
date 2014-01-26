import UnityEngine
import System.Collections

public class rotating (MonoBehaviour):
	
	public speed as single = 300.0F
	
	def Update ():
		if Input.GetKeyDown(KeyCode.S):
			transform.Rotate(Vector3.fwd, 120)

		if Input.GetMouseButtonDown(0):
			transform.Rotate(Vector3.fwd, 120)
