using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blokken : MonoBehaviour 
{
	float snelheid;

	// Use this for initialization
	void Start () 
	{
		snelheid = Random.Range (0.8f, 1.2f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (-snelheid * Time.deltaTime, 0, 0);
	}
}
