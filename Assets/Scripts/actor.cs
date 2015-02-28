using UnityEngine;
using System.Collections;

public abstract class actor : MonoBehaviour {

	private Animator anim;
	private int facing;
	private bool moving;
	
	// Use this for initialization
	public void Start () {
		
		anim = this.GetComponent<Animator>();
		moving = false;
		facing = 2;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		animacionMovimiento(movimiento ());
		transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y);
	}

	public abstract float[]  movimiento ();


	void animacionMovimiento(float [] move){
		//codigo para la animacion
		moving = move[0] != 0 || move[1] != 0;
		if (moving) {
			if (move[1] > 0) facing = 8;
			else if (move[1] < 0)facing = 2;
			else if (move[0] > 0) facing = 6;
			else facing = 4;
		}
		
		anim.SetBool("moving",moving);
		anim.SetInteger ("facing", facing);
	}
}
