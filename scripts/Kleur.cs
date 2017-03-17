using UnityEngine;
using System.Collections;

public class Kleur : MonoBehaviour 
{
	public GameObject kubus;

	// Use this for initialization
	void Start () 
	{
		kubus = GameObject.Find ("kleur");
		GetComponent<Renderer> ().material.color = kubus.GetComponent<Renderer>().material.GetColor ("_Color");

	//	print (kubus.GetComponent<Material>());
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
