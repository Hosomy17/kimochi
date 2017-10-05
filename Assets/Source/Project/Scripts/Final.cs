using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("Quit", 17l);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void Quit(){
		GameManagerGeneric.Instance.CloseGame ();
	}
}
