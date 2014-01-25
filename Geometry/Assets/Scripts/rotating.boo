import UnityEngine
import System.Collections

public class rotating (MonoBehaviour):
	
	public speed as single = 300.0F
	
	def Update ():
		if Input.GetKey(KeyCode.S):
			transform.Rotate(Vector3.fwd, (speed * Time.deltaTime))
		
