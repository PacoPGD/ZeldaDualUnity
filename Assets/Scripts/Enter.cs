using UnityEngine;
using System.Collections;

public class Enter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("A1")!=0){ 
			Application.LoadLevel ("eligePartida"); 
		} 
	}
}
