using UnityEngine;
using System.Collections;

public abstract class Actor : MonoBehaviour {

	protected Animator anim;
	protected int facing;
	protected bool moving;
	protected float[] movimientoHecho;
	protected float maxVelocity;
	
	// Use this for initialization
	public void Start () {
		anim = this.GetComponent<Animator>();
		moving = false;
		facing = 2;
		movimientoHecho = new float[2];
		maxVelocity = 6;
	}
	
	// Update is called once per frame
	public void Update () 
	{
		movimiento ();
		animacionMovimiento();

		//Linea equivalente el script perspectiva.
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.y/100000);

		//El rigidbody de todos los actores tiene ahora una velocidad maxima controlada por el atributo privado maxVelocity.
		//Basicamente si su velocidad en cualquier momento supera maxVelocity, la velocidad se iguala a maxVelocity.
		//Esto crea una velocidad diagonal mas normal, pero podria darnos problemas si queremos darle un movimiento muy rapido de repente a un actor.
		if (rigidbody2D.velocity.magnitude > maxVelocity) {
			rigidbody2D.velocity = rigidbody2D.velocity.normalized * maxVelocity;
		}
	}

	//Devuelve una array de 2 floats. Con valors mayores, menores o iguales que 0.(generalmente -1,0 o 1)
	//En la posicion 0, movimiento horizontal, en la posicion 1 movimiento vertical.
	//Ademas, el metodo debe realizar el movimiento.
	public abstract void movimiento ();


	public void animacionMovimiento(){
		//codigo para la animacion
		moving = movimientoHecho[0] != 0 || movimientoHecho[1] != 0;
		if (moving) {
			if (movimientoHecho[1] > 0) facing = 8;
			else if (movimientoHecho[1] < 0)facing = 2;
			else if (movimientoHecho[0] > 0) facing = 6;
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
