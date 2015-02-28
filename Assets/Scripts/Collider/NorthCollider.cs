using UnityEngine;
using System.Collections;

public class NorthCollider : MonoBehaviour {
	
	void OnTriggerStay2D(Collider2D other){
		if(other.gameObject.name.Equals("Jugador1") || other.gameObject.name.Equals("Jugador2")){
			Jugador player = other.GetComponent<Jugador>();
			player.setY (player.getY ()-0.5f);  
		}
	}
}
