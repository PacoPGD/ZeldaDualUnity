using UnityEngine;
using System.Collections;

public class movimientoJugador : MonoBehaviour {


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		movimiento ();
	}

	void movimiento()
	{
		float movimientoHorizontal = Input.GetAxis ("Horizontal");
		float movimientoVertical = Input.GetAxis ("Vertical");

		if(movimientoHorizontal==1 && movimientoVertical ==1)
			rigidbody2D.velocity = new Vector2 (movimientoHorizontal * 7.07, movimientoVertical * 7.07);
		else
			rigidbody2D.velocity = new Vector2 (movimientoHorizontal * 10, movimientoVertical * 10);
	}
}
