using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class prueba : MonoBehaviour 
{
	public float speed;
	public Boundary boundary;
	public float tilt;
	
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rigidbody.velocity = movement * speed;
		
		rigidbody.position = new Vector2
			(
				Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax),
				Mathf.Clamp (rigidbody.position.z, boundary.zMin, boundary.zMax)
				);
		
	}
	
	
}