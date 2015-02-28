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
		setX ((jugador1.getX()+jugador2.getX())/2);
		setY ((jugador1.getY()+jugador2.getY())/2);
	}




	public float getX(){
		return transform.position.x;
	}
	
	public float getY(){
		return transform.position.y;
	}
	
	public void setX(float x){
		transform.position = new Vector3(x, transform.position.y, transform.position.z);
	}
	
	public void setY(float y){
		transform.position = new Vector3(transform.position.x, y, transform.position.z);
	}
}
