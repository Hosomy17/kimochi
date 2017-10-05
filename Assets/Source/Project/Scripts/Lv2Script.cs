using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv2Script : ScriptGeneric
{
	public GameObject cursor;
	public GameObject[] objs;
	public Vector3 solution;

	void Start()
	{
		var c = new CursorController ();
		c.TrackObject (cursor);
		GetComponent<Gamepad>().controller = c;
		solution = cursor.GetComponent<CursorClass> ().solution;
	}

	void Update()
	{
		var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		pos.z = 0;
		cursor.transform.localPosition = pos;

		objs [0].transform.eulerAngles =  Vector3.forward * (cursor.transform.localPosition.x - solution.x);
		objs [1].transform.eulerAngles = -Vector3.forward * (cursor.transform.localPosition.y - solution.y)*1.4f;
		objs [2].transform.eulerAngles =  Vector3.forward * (cursor.transform.localPosition.x - solution.x) * 1.2f;
		objs [3].transform.eulerAngles = -Vector3.forward * (cursor.transform.localPosition.y- solution.y)*1.3f;
		objs [4].transform.eulerAngles =  Vector3.forward * (cursor.transform.localPosition.y- solution.y)*1.3f;
		objs [5].transform.eulerAngles = -Vector3.forward * (cursor.transform.localPosition.x- solution.x)*1.2f;
		objs [6].transform.eulerAngles =  Vector3.forward * (cursor.transform.localPosition.x- solution.x)*1.4f;
		objs [7].transform.eulerAngles = -Vector3.forward * (cursor.transform.localPosition.y- solution.y);
	}
}
