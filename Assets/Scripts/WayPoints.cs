using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour {
	public Transform WayPoint1;
	public Transform WayPoint2;
	public Transform WayPoint3;
	public Transform WayPoint4;

	public float VelCaminar;
	public bool Cambio1 = true;
	public bool Cambio2;
	public bool Cambio3;
	public bool Cambio4;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Cambio1) 
		{
			transform.LookAt (new Vector3 (WayPoint1.position.x, WayPoint1.position.y, WayPoint1.position.z));
			transform.Translate (0, 0, VelCaminar * Time.deltaTime);
		}

		if (Cambio2) 
		{
			transform.LookAt (new Vector3 (WayPoint2.position.x, WayPoint2.position.y, WayPoint2.position.z));
			transform.Translate (0, 0, VelCaminar * Time.deltaTime);
		}
		if (Cambio3) 
		{
			transform.LookAt (new Vector3 (WayPoint3.position.x, WayPoint3.position.y, WayPoint3.position.z));
			transform.Translate (0, 0, VelCaminar * Time.deltaTime);
		}

		if (Cambio4) 
		{
			transform.LookAt (new Vector3 (WayPoint4.position.x, WayPoint4.position.y, WayPoint4.position.z));
			transform.Translate (0, 0, VelCaminar * Time.deltaTime);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "WayPoint1") 
		{
			Cambio1 = false;
			Cambio2 = true;
		}

		if (other.gameObject.tag == "WayPoint2") 
		{
			Cambio2 = false;
			Cambio3 = true;
		}

		if (other.gameObject.tag == "WayPoint3") 
		{
			Cambio3 = false;
			Cambio4 = true;
		}

		if (other.gameObject.tag == "WayPoint4") 
		{
			Cambio4 = false;
			Cambio1 = true;
		}
	}
}
