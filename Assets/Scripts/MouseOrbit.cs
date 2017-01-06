using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOrbit : MonoBehaviour {
	private float MoveDer_Izq = 0.0f;
	private float MoveUp_Dawn = 0.0f;
	public float VelRotaH = 5.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		MoveDer_Izq += VelRotaH * Input.GetAxis ("Mouse X");
		MoveUp_Dawn += VelRotaH * Input.GetAxis ("Mouse Y");

		transform.eulerAngles = new Vector3 (MoveUp_Dawn, MoveDer_Izq);

		if (MoveUp_Dawn >= 77f) 
		{
			MoveUp_Dawn = 77f;
		}

		if (MoveUp_Dawn <= -50f) 
		{
			MoveUp_Dawn = -50f;
		}
	}
}
