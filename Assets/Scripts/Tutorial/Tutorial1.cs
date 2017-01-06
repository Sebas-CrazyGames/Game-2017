using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial1 : MonoBehaviour {
	public GameObject[] Textos;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Invoke ("CambioTexto", 3f);
	}

	public void CambioTexto()
	{
		Textos [0].SetActive (false);
		Textos [1].SetActive (true);
	}
}
