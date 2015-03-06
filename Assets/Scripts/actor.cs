using UnityEngine;
using System.Collections;

public abstract class Actor : MonoBehaviour {

	public int vidaMax;
	protected int vida;
	
	protected Animator anim;
	int facing = 2;
	bool moving = false;

	// Use this for initialization
	public void Start () {
		anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	public void Update () 
	{
		animacionMovimiento(movimiento ());

		//Linea equivalente el script perspectiva.
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.y/100000);
	}

	//Devuelve una array de 2 floats. Con valors mayores, menores o iguales que 0.(generalmente -1,0 o 1)
	//En la posicion 0, movimiento horizontal, en la posicion 1 movimiento vertical.
	//Ademas, el metodo debe realizar el movimiento.
	public abstract float[] movimiento ();


	public void animacionMovimiento(float [] movimientoHecho){
		if (Mathf.Abs (movimientoHecho [0]) > 0.4 || Mathf.Abs (movimientoHecho [1]) > 0.4)
			moving = true;
		else
			moving = false;

		//codigo para la animacion
		if (moving) {
			if(Mathf.Abs (movimientoHecho[0]) > Mathf.Abs (movimientoHecho[1])){
				if (movimientoHecho[0] > 0) facing = 6;
				else facing = 4;
			}
			else{
				if (movimientoHecho[1] > 0) facing = 8;
				else facing = 2;
			}
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
