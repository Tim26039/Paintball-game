using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
	int nul = 0;

	// Use this for initialization
	void Start () 
	{
		PlayerPrefs.SetInt ("Rood", nul);
		PlayerPrefs.SetInt ("Blauw", nul);
		PlayerPrefs.SetInt ("Geel", nul);
		PlayerPrefs.SetInt ("Groen", nul);
		PlayerPrefs.SetInt ("Zwart", nul);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
