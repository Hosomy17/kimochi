using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : ScriptGeneric {
	
	void Start () {
		DontDestroyOnLoad (gameObject);

		Cursor.lockState = CursorLockMode.Confined;
		Cursor.visible = false;
	}

	void Update(){
		if (Input.GetButtonDown ("Fire3"))
			GameManagerGeneric.Instance.CloseGame ();
	}

}
