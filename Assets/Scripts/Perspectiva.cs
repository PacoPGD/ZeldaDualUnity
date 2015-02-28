using UnityEngine;
using System.Collections;

public class Perspectiva : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.y/100000);
	}

}
