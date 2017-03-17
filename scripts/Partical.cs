using UnityEngine;
using System.Collections;

public class Partical : MonoBehaviour
{
	float tijd = 0.5f;
	private AudioSource soundeffect;
	public AudioClip hitsound;


	// Use this for initialization
	void Start () 
	{
		soundeffect = GetComponent<AudioSource>();
		soundeffect.PlayOneShot (hitsound);
	}

	// Update is called once per frame
	void Update () 
	{
		tijd -= Time.deltaTime;

		if (tijd <= 0) 
		{
			Destroy (gameObject);
		}
	}
}
