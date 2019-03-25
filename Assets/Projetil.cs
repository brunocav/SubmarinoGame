using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (1.0f,0.0f,0.0f);
	}
}
