using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : ControllerGeneric
{
	private CursorClass cursor;
	private Rigidbody2D rb;
	public override void NewInputs (Dictionary<string, object> ipt)
	{
		if (ipt ["Fire3"] == "Down")
			GameManagerGeneric.Instance.CloseGame ();
			
		var speed = cursor.speed;
		speed *= (ipt ["Fire2"] == "Hold") ? 3 : 1;
		Move ((Vector2)ipt ["Axis"], speed);

		if (ipt ["Fire1"] == "Down")
			Verify ();


	}
	public override void TrackObject (GameObject obj)
	{
		cursor = obj.GetComponent<CursorClass>();
		rb = obj.GetComponent<Rigidbody2D> ();
		Vector2 pos = Vector2.one;
		Vector2 sol = Vector2.one;
		int aux = 0;
		do {
			pos.x = Random.Range (-390, 370);
			sol.x = Random.Range (-390, 370);
			aux = (int) Mathf.Abs (pos.x - sol.x);
		} while(aux < 100);

		do {
			pos.y = Random.Range (-290,250);
			sol.y = Random.Range (-290,250);
			aux = (int) Mathf.Abs (pos.x - sol.x);
		} while(aux < 100);

		cursor.transform.localPosition = pos;
		cursor.solution = sol;
		
	}

	public void Move(Vector2 dir, float speed)
	{	
		rb.velocity = dir * speed;
	}

	public void Verify()
	{
		var pos = cursor.gameObject.transform.localPosition;
		if (Mathf.Abs(Mathf.Round(pos.x - cursor.solution.x + pos.y - cursor.solution.y)) <= cursor.dif)
		{
			GameManagerGeneric.Instance.LoadScene (cursor.nextLv);
		}
	}
}
