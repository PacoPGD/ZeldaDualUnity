using UnityEngine;
using System.Collections;

public class Hablador : MonoBehaviour {

	public string mensaje;
	private bool hablar;

	void Start () {
		hablar = false;
	}
	
	void OnTriggerStay2D(Collider2D other){
		if(other.gameObject.name.Equals("Jugador1")){
			if(Input.GetAxis ("A1")!=0)
				//imprimeMensaje();
				hablar = true;
		}
		if(other.gameObject.name.Equals("Jugador2")){
			if(Input.GetAxis ("A2")!=0)
				//imprimeMensaje();
				hablar = true;
		}
	}

	void imprimeMensaje(){
		Debug.Log (mensaje);
		//GUI.Box(Rect (Screen.width/2-(PosX/2), Screen.height/2-(PosY/2), PosX, PosY),mensaje);
	}

	void OnGUI() {
		if (hablar) {
			Debug.Log (mensaje);
			//GUILayout.BeginArea(new Rect(0,0,Screen.width,Screen.height));
			//GUI.Label(new Rect(10, 10, 100, 20), "Hello World!");
			//GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "This is a title");
			//GUILayout.Label(mensaje);
			hablar = false;
			//GUILayout.EndArea();
		} 
	}
}
