using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour {
	public GameObject ArmaP,Projetil;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")){
			StartCoroutine (ArmarAtira());
		}
	}
	IEnumerator ArmarAtira(){
		yield return new WaitForSeconds (0.4f);
		Instantiate (Projetil, ArmaP.transform.position, ArmaP.transform.rotation);

	}
}
