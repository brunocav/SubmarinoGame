using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float velocidade = 3;
	float rote = 5.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		movimento ();
			
	}
	void movimento () {
		rote += Input.GetAxis ("Horizontal") * velocidade * Time.deltaTime;
		float y = Input.GetAxis ("Vertical") * velocidade * Time.deltaTime;
		//transform.Translate (0.0f, rote, y);
		//transform.eulerAngles = new Vector3 (10, rote, y);

	
	}
}
