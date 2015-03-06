using UnityEngine;
using System.Collections;

public class Jugador : Actor {

	Texture2D corazon;

	public int nJugador;

	public void Start () {
		base.Start ();
		vidaMax = 30;
		vida = vidaMax;
		corazon = (Texture2D)Resources.Load("BackGround/corazon/corazonlleno.png");
	}

	public void Update() {
		base.Update ();
	}
	
	public override float[] movimiento (){
		float [] move = new float[2];
		float speed = 6;
		
		
		if (nJugador == 1) {
			move[0] = Input.GetAxis ("Horizontal1");
			move[1] = Input.GetAxis ("Vertical1");
		} 
		else {
			move[0] = Input.GetAxis ("Horizontal2");
			move[1] = Input.GetAxis ("Vertical2");
		}
		
		if (move [0] != 0 && move [1] != 0) 
			speed = Mathf.Sqrt (Mathf.Pow (speed, 2) * 2) / 2;
			
		GetComponent<Rigidbody2D>().velocity = new Vector2 (move[0] * speed, move[1] * speed);

		return move;
	}

	void OnGUI(){
		if (nJugador == 1) {
			GUI.Label (new Rect (0,0,100,50), corazon);
		}
	}



}
