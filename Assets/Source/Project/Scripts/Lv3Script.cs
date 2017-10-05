using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv3Script : ScriptGeneric
{
	public GameObject cursor;
	public GameObject[] objs;
	public GameObject[] camera;
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

		objs[0].transform.localPosition  =  Vector2.right * (cursor.transform.localPosition.x -solution.x);
		objs[1].transform.localPosition  =  Vector2.up * (cursor.transform.localPosition.y - solution.y);
		objs[2].transform.localPosition  = -Vector2.right * (cursor.transform.localPosition.x-solution.x);
		objs[3].transform.localPosition  = -Vector2.up * (cursor.transform.localPosition.y- solution.y);
		objs[4].transform.localPosition  = -Vector2.right * (cursor.transform.localPosition.x-solution.x)*2;
		objs[5].transform.localPosition  = -Vector2.up * (cursor.transform.localPosition.y- solution.y)*2;
		objs[6].transform.localPosition  =  Vector2.right * (cursor.transform.localPosition.x-solution.x) * 2;
		objs[7].transform.localPosition  =  Vector2.up * (cursor.transform.localPosition.y- solution.y)*2;
		objs[8].transform.localPosition  =  Vector2.right * (cursor.transform.localPosition.x-solution.x)*3;
		objs[9].transform.localPosition  =  Vector2.up * (cursor.transform.localPosition.y- solution.y) * 2;
		objs[10].transform.localPosition = -Vector2.right * (cursor.transform.localPosition.x-solution.x)*3;
		objs[11].transform.localPosition = -Vector2.up * (cursor.transform.localPosition.y- solution.y)*3;
		objs[12].transform.localPosition = -Vector2.right * (cursor.transform.localPosition.x-solution.x)*3;

		camera [0].transform.localPosition = -Vector3.up * (cursor.transform.localPosition.y + 600 - solution.y) + Vector3.forward * -10;
		camera [1].transform.localPosition = -Vector3.right * (cursor.transform.localPosition.x + 800 - solution.x)+ Vector3.forward * -10;
		camera [2].transform.localPosition = Vector3.right * (cursor.transform.localPosition.x - 800 - solution.x)+ Vector3.forward * -10;
		camera [3].transform.localPosition =  Vector3.up * (cursor.transform.localPosition.y - 600 - solution.y)+ Vector3.forward * -10;

	}
}
