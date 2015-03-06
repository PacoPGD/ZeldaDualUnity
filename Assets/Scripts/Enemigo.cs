using UnityEngine;
using System.Collections;

public class Enemigo : Actor {


	public float velocidad;
	public float destinoX;
	public float destinoY;

	private float origenX;
	private float origenY;

	// Use this for initialization
	void Start () {
		base.Start ();
		origenX = getX ();
		origenY = getY ();
	}
	
	// Update is called once per frame
	void Update () {
		base.Update ();
	}

	public override float[] movimiento () {
		float speed = 6;
		return patrullar (speed); //El enemigo siempre esta patrullando, mas adelante incluire aqui formas de movimiento alternativas, como seguir al jugador.
	}

	/*void moverseHacia(float x, float y ) {
		float [] move = {0,0}; //Por defecto no se mueve.
		float actualX = getX ();
		float actualY = getY ();

		if (((actualX < destinoX && actualX > destinoX-0.25) || (actualX > destinoX && actualX < destinoX+0.25)) &&
		    ((actualY < destinoY && actualY > destinoY-0.25) || (actualY > destinoY && actualY < destinoY+0.25))) {
			//DESTINO ALCANZADO
		}

	}*/

	public float[] patrullar(float speed) {
		float [] move = {0,0}; //Por defecto no se mueve.
		float actualX = getX ();
		float actualY = getY ();


		//Si el enemigo llega a la posicion de destino, cambio una por otra las posiciones de origen y destino.
		//De esta forma, el enemigo siempre esta patrullando en una direccion u otra.
		if (((actualX < destinoX && actualX > destinoX-0.25) || (actualX > destinoX && actualX < destinoX+0.25)) &&
		    ((actualY < destinoY && actualY > destinoY-0.25) || (actualY > destinoY && actualY < destinoY+0.25))) {

			Debug.Log("DESTINO ALCANZADO");
			float save = destinoX; //variable auxiliar.
			destinoX = origenX;
			origenX = save;
			
			save = destinoY;
			destinoY = origenY;
			origenY = save;
		}

		//Decido si se va a mover en el eje X segun su posicion actual y la de destino.
		if (actualX < destinoX -0.20) {
			Debug.Log ("X POSITIVA");
			move [0] = 1;
		} else if (actualX > destinoX +0.20) {
			Debug.Log ("X NEGATIVA");
			move[0] = -1;
		}
		
		//Decido si se va a mover en el eje Y segun su posicion actual y la de destino.
		if (actualY < destinoY -0.20) {
			Debug.Log ("Y POSITIVA");
			move [1] = 1;
		} else if (actualY > destinoY +0.20) {
			Debug.Log ("Y NEGATIVA");
			move[1] = -1;
		}

		//Ajuste de velocidad diagonal.
		//if (move [0] != 0 && move [1] != 0) 
		//	speed = Mathf.Sqrt (Mathf.Pow (velocidad, 2) * 2) / 2;
		
		GetComponent<Rigidbody2D>().velocity = new Vector2 (move[0] * speed, move[1] * speed); //Realizo el movimiento

		return move;
	}	
}
