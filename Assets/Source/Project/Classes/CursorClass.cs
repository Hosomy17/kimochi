using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorClass : ClassGeneric
{
	public float speed;
	public string nextLv;
	public Vector2 solution;
	public int dif;

	void OnCollisionExit2D(Collision2D c)
	{
		var pos = transform.localPosition;
		pos.x = Mathf.Floor (pos.x);
		pos.y = Mathf.Floor (pos.y);
		transform.localPosition = pos;

	}
}
