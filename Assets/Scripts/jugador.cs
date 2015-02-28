using UnityEngine;
using System.Collections;

public class Jugador : Actor {

	public int nJugador;
	
	public override float[]  movimiento (){
		float [] move = new float[2];
		
		
		if (nJugador == 1) {
			move[0] = Input.GetAxis ("Horizontal1");
			move[1] = Input.GetAxis ("Vertical1");
		} 
		else {
			move[0] = Input.GetAxis ("Horizontal2");
			move[1] = Input.GetAxis ("Vertical2");
		}
		
		float velocidad = 5;
		
		if (move [0] != 0 && move [1] != 0) 
			velocidad = Mathf.Sqrt (Mathf.Pow (velocidad, 2) * 2) / 2;
			
		rigidbody2D.velocity = new Vector2 (move[0] * velocidad, move[1] * velocidad);
		
		return move;
	}

}
