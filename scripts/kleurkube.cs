using UnityEngine;
using System.Collections;

public class kleurkube : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		GetComponent<Renderer> ().material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Alpha1))
		{
			GetComponent<Renderer> ().material.color = Color.red;
		}

		if (Input.GetKeyDown (KeyCode.Alpha2))
		{
			GetComponent<Renderer> ().material.color = Color.blue;
		}

		if (Input.GetKeyDown (KeyCode.Alpha3))
		{
			GetComponent<Renderer> ().material.color = Color.green;
		}

		if (Input.GetKeyDown (KeyCode.Alpha4))
		{
			GetComponent<Renderer> ().material.color = Color.yellow;
		}

		if (Input.GetKeyDown (KeyCode.Alpha5))
		{
			GetComponent<Renderer> ().material.color = Color.black;
		}
	}
}
