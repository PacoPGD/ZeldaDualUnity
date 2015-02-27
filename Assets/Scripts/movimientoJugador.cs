using UnityEngine;
using System.Collections;

public class movimientoJugador : MonoBehaviour {

	public int jugador;
	private Animator anim;
	private int facing;
	private bool moving;

	// Use this for initialization
	void Start () {

		anim = this.GetComponent<Animator>();
		moving = false;
		facing = 2;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		movimiento ();
	}

	void movimiento()
	{
		float movimientoHorizontal;
		float movimientoVertical;

		if (jugador == 1) {
			movimientoHorizontal = Input.GetAxis ("Horizontal1");
			movimientoVertical = Input.GetAxis ("Vertical1");
		} 
		else {
			movimientoHorizontal = Input.GetAxis ("Horizontal2");
			movimientoVertical = Input.GetAxis ("Vertical2");
		}

		//codigo para la animacion
		moving = movimientoHorizontal != 0 || movimientoVertical != 0;
		if (moving) {
			if (movimientoVertical > 0) facing = 8;
			else if (movimientoVertical < 0)facing = 2;
			else if (movimientoHorizontal > 0) facing = 6;
			else facing = 4;
		}

		float velocidad = 10;
	
		if (movimientoHorizontal != 0 && movimientoVertical != 0)
			velocidad = Mathf.Sqrt(Mathf.Pow(velocidad,2)*2)/2;

		rigidbody2D.velocity = new Vector2 (movimientoHorizontal * velocidad, movimientoVertical * velocidad);

		anim.SetBool("moving",moving);
		anim.SetInteger ("facing", facing);
	}
}
