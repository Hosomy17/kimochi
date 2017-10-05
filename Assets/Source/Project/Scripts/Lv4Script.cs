using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv4Script : ScriptGeneric
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

		objs [0].transform.eulerAngles = Vector3.forward * (cursor.transform.localPosition.x + cursor.transform.localPosition.y - solution.x - solution.y) * 3f;

		objs [1].transform.eulerAngles = -Vector3.forward * (cursor.transform.localPosition.x + cursor.transform.localPosition.y - solution.x - solution.y) * 2.5f;
		//objs [1].transform.localScale  = Vector2.one * (1.25f - ((cursor.transform.localPosition.x - solution.x + 1) % 3 * 0.25f));

		objs [2].transform.eulerAngles = Vector3.forward * (cursor.transform.localPosition.x + cursor.transform.localPosition.y - solution.x - solution.y) * 3f;
		//objs [2].transform.localScale  = Vector2.one * (1.5f - ((cursor.transform.localPosition.y - solution.y + 2) % 4 * 0.25f));

		objs [3].transform.eulerAngles = Vector3.forward * (cursor.transform.localPosition.x + cursor.transform.localPosition.y - solution.x - solution.y) * 2.5f;
		//objs [3].transform.localScale  = Vector2.one * (1.3f - ((cursor.transform.localPosition.y - solution.y + 3) % 7 * 0.1f));

		objs [4].transform.eulerAngles = -Vector3.forward * (cursor.transform.localPosition.x + cursor.transform.localPosition.y - solution.x - solution.y) * 2f;
		//objs [4].transform.localScale  = Vector2.one * (1.4f - ((cursor.transform.localPosition.x - solution.x + 2) % 5 * 0.2f));

		objs [5].transform.eulerAngles = -Vector3.forward * (cursor.transform.localPosition.x + cursor.transform.localPosition.y - solution.x - solution.y);

		objs [6].transform.localPosition = Vector2.up * (cursor.transform.localPosition.y - solution.y);
		objs [7].transform.localPosition = -Vector2.up * (cursor.transform.localPosition.y - solution.y);

		objs [8].transform.localPosition = Vector2.right * (cursor.transform.localPosition.x - solution.x);
		objs [9].transform.localPosition = -Vector2.right * (cursor.transform.localPosition.x - solution.x);

		//objs [10].transform.localScale = Vector2.one * (1.5f - ((cursor.transform.localPosition.x - solution.x + 10) % 20 * 0.05f));
		objs [10].transform.eulerAngles = Vector3.forward * (cursor.transform.localPosition.y - solution.y);


	}
}
