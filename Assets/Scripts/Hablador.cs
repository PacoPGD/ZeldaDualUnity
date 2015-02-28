using UnityEngine;
using System.Collections;

public class Hablador : MonoBehaviour {

	public string mensaje;

	
	void OnTriggerStay2D(Collider2D other){
		if(other.gameObject.name.Equals("Jugador1")){
			if(Input.GetAxis ("A1")!=0)
				imprimeMensaje();
		}
		if(other.gameObject.name.Equals("Jugador2")){
			if(Input.GetAxis ("A2")!=0)
				imprimeMensaje();
		}
	}

	void imprimeMensaje(){
		Debug.Log (mensaje);
		//GUI.Box(Rect (Screen.width/2-(PosX/2), Screen.height/2-(PosY/2), PosX, PosY),mensaje);
		OnGUI ();
	}

	void OnGUI() {
		GUI.Box(new Rect(5,5,5,5), mensaje); 
	}
}
