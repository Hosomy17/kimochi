using UnityEngine;
using System.Collections.Generic;
using System;

/// <summary>
/// Check gamepad with 3 buttons and directional
/// buttons can be {Down,Up,Hold,Idle}
/// directional is x = [-1,0,1], y [-1,0,1]
/// </summary>
public class Gamepad : GamepadGeneric
{
    public Dictionary<string,object> inputs;

    void Awake()
    {
		inputs = new Dictionary<string, object>();

		inputs.Add("Fire1", "Idle");
		inputs.Add("Fire2", "Idle");
		inputs.Add("Fire3", "Idle");
		inputs.Add("Axis" , Vector2.zero);
	}

	void Update ()
    {
		try
		{
	        for (int i = 1; i <= 3; i++)
			{

				inputs["Fire" + i]  = Input.GetButtonDown ("Fire" + i) ? "Down" :
									  Input.GetButton ("Fire" + i) 	   ? "Hold" :
								      Input.GetButtonUp ("Fire" + i)   ? "Up"   : "Idle";
	        }

			inputs["Axis"] = GetAxis();
			controller.NewInputs(inputs);
		}
		catch//(Exception e)
		{
			//Debug.LogError(e);
		}
	}

    private Vector2 GetAxis()
    {
        Vector2 axis = new Vector2();

		axis.x = Input.GetAxisRaw("Horizontal");
		axis.y = Input.GetAxisRaw("Vertical");

        return axis;
    }
}
