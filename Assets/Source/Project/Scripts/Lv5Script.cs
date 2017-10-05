using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv5Script : ScriptGeneric
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

		objs [0].transform.localPosition  = -Vector2.up * (cursor.transform.localPosition.y - solution.y);
		objs [1].transform.localPosition  = Vector2.up  * (cursor.transform.localPosition.y - solution.y);
		objs [2].transform.localPosition  = -Vector2.up    * ((cursor.transform.localPosition.x - solution.x) * 2);
		objs [3].transform.localPosition  = Vector2.up  * ((cursor.transform.localPosition.x - solution.x) * 2);
		objs [4].transform.localPosition  = -Vector2.up    * ((cursor.transform.localPosition.y - solution.y) * 3);
		objs [5].transform.localPosition  = Vector2.right  * ((cursor.transform.localPosition.x - solution.x) * 3);
		objs [6].transform.localPosition  = Vector2.right  * ((cursor.transform.localPosition.x - solution.x) * 4);
		objs [7].transform.localPosition  = Vector2.up     * ((cursor.transform.localPosition.y - solution.y) * 4);
		objs [8].transform.localPosition  = -Vector2.up * ((cursor.transform.localPosition.x - solution.x) * 2);
		objs [9].transform.localPosition  = Vector2.right  * ((cursor.transform.localPosition.x - solution.x) * 3);
		objs [10].transform.localPosition = -Vector2.right * ((cursor.transform.localPosition.y - solution.y) * 4);
	}
}