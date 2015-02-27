using UnityEngine;
using System.Collections;

public class movimientoJugador : MonoBehaviour {

	public int jugador=0;

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


		float velocidad = 10;
	
		if (movimientoHorizontal != 0 && movimientoVertical != 0)
			velocidad = Mathf.Sqrt(Mathf.Pow(velocidad,2)*2)/2;

		rigidbody2D.velocity = new Vector2 (movimientoHorizontal * velocidad, movimientoVertical * velocidad);

	}
}
