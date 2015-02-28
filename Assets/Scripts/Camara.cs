using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour {

	public Jugador jugador1;
	public Jugador jugador2;

	public void Start(){
	
	}

	public void Update(){
		seguimiento ();
	}

	public void seguimiento(){

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
		transform.position = new Vector3(transform.position.x, y, transform.position.y);
	}
}
