using UnityEngine;
using System.Collections;

public class schieten : MonoBehaviour 
{
	public Transform Kogel;
	int raycastLength = 1000;
	public Texture dot;
	new Rect RichtPunt;
	new Vector3 rayPositie;
	public Material groen;
	bool hitting;
	GameObject auto;

	private AudioSource soundeffect;
	public AudioClip shootsound;


	float folume;
	float richtPuntSize;

	// Use this for initialization
	void Start ()
	{
		//GetComponent<Renderer>().material.color = Color.red;
		soundeffect = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		richtPuntSize = Screen.width*0.03f;
		RichtPunt = new Rect (Screen.width / 1.94f - richtPuntSize / 2, Screen.height / 1.9f - richtPuntSize / 2, richtPuntSize, richtPuntSize);

	//	RichtPunt = new Rect (Screen.width / 2 , , , )
		if (Input.GetMouseButtonDown(0))
		{
			folume = Random.Range (0.5f, 1.0f);
			soundeffect.PlayOneShot (shootsound, folume);
			Instantiate (Kogel, new Vector3 (transform.position.x, transform.position.y + 0.2f,  transform.position.z), Quaternion.identity);

		}

			
		rayPositie = new Vector3 (transform.position.x + 0.23f, transform.position.y + 0.2f, transform.position.z);
		Ray ray = new Ray(rayPositie, -transform.forward);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, raycastLength)) 
		{
			hitting = true;

			if (hit.collider.tag == "rood" || hit.collider.tag == "blauw" || hit.collider.tag == "groen" || hit.collider.tag == "geel" || hit.collider.tag == "zwart" ) 
			{
				hit.collider.GetComponent<Renderer> ().material.color = Color.green;
				auto = hit.collider.transform.gameObject;
			}
				
		}

		if (hitting == false && auto != null) 
		{
			auto.GetComponent<Collider>().GetComponent<Renderer> ().material.color = Color.white;
		}


		hitting = false;
			
			
		//GetComponent<Material> () = groen;
	}

	void OnGUI()
	{
		GUI.DrawTexture (RichtPunt, dot);
	}
}
