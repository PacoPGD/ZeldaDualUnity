using UnityEngine;
using System.Collections;

public abstract class Actor : MonoBehaviour {

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
	public void Update () 
	{
		animacionMovimiento(movimiento ());
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.y/100000);
	}

	public abstract float[]  movimiento ();


	public void animacionMovimiento(float [] move){
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

	public float getX(){
		return transform.position.x;
	}
	
	public float getY(){
		return transform.position.y;
	}
	
	public void setX(float x){
		transform.position = new Vector3(x, transform.position.y, transform.position.y);
	}
	
	public void setY(float y){
		transform.position = new Vector3(transform.position.x, y, y);
	}
}
