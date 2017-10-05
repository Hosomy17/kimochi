using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv0Script : ScriptGeneric
{
	public GameObject cursor;
	public GameObject[] objs;
	public Vector3 solution;

	void Start()
	{
		var c = new CursorController ();
		var pos = cursor.transform.localPosition;
		c.TrackObject (cursor);

		cursor.transform.localPosition = pos;
		cursor.GetComponent<CursorClass> ().solution = Vector2.zero;

		GetComponent<Gamepad>().controller = c;
	}
	void Update()
	{
		var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		pos.z = 0;
		cursor.transform.localPosition = pos;

		objs [0].transform.localPosition = - (cursor.transform.localPosition);
		objs [1].transform.localPosition = (cursor.transform.localPosition);
		objs [2].transform.localEulerAngles = Vector3.forward * (cursor.transform.localPosition.y);
	}
}
