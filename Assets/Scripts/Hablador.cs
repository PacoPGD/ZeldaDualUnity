using UnityEngine;
using System.Collections;

public class Hablador : MonoBehaviour {

	public string mensaje;
	string mostrado;
	private bool hablar;

	void Start () {
		hablar = false;
	}

	void Update(){
	}

	void OnTriggerStay2D(Collider2D other){
		if(other.gameObject.name.Equals("Jugador1")){
			if(Input.GetAxis ("A1")!=0)
				hablar = true;
		}
		if(other.gameObject.name.Equals("Jugador2")){
			if(Input.GetAxis ("A2")!=0)
				hablar = true;
		}
	}


	void OnGUI() {
		if (hablar == true) {
			GUI.Box (new Rect (150,450,700,100), mensaje);
		}
	}
}
