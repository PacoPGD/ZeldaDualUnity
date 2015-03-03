using UnityEngine;
using System.Collections;

public class Jugador : Actor {

	public int nJugador;
	private float velocidad;

	public void Start () {
		base.Start ();
		velocidad = 6;
	}

	public void Update() {
		base.Update ();
	}
	
	public override void  movimiento (){
		float [] move = new float[2];
		float speed = velocidad;
		
		
		if (nJugador == 1) {
			move[0] = Input.GetAxis ("Horizontal1");
			move[1] = Input.GetAxis ("Vertical1");
		} 
		else {
			move[0] = Input.GetAxis ("Horizontal2");
			move[1] = Input.GetAxis ("Vertical2");
		}
		
		//if (move [0] != 0 && move [1] != 0) 
		//	speed = Mathf.Sqrt (Mathf.Pow (speed, 2) * 2) / 2;
			
		rigidbody2D.velocity = new Vector2 (move[0] * speed, move[1] * speed);

		movimientoHecho = move;
	}

}
