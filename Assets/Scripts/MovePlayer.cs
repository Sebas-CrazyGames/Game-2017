using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {
	public float VelocidadMove;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		CharacterController Control = GetComponent<CharacterController> ();
		Vector3 Adelante = transform.TransformDirection (Vector3.forward);
		Vector3 Der_Izq = transform.TransformDirection (Vector3.right);
		float VelMove = VelocidadMove * Input.GetAxis ("Vertical");
		float VelMove2 = VelocidadMove * Input.GetAxis ("Horizontal");

		Control.SimpleMove (Adelante * VelMove);
		Control.SimpleMove (Der_Izq * VelMove2);
	}
}
