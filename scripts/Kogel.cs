using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Kogel : MonoBehaviour
{
	float snelheid;
	GameObject speler;
	Vector3 rotatie;

	public GameObject kubus;
	//public GameObject groen;

	string RoodT = "1. Rood: ";
	string BlauwT = "2. Blauw: ";
	string GroenT = "3. groen: ";
	string GeelT = "3. geel: ";
	string ZwartT = "3. zwart: ";

	int ScoreRood ;
	int ScoreBlauw ;
	int ScoreGroen ;
	int ScoreGeel ;
	int ScoreZwart ;

	public ParticleSystem particleSystem;
	public ParticleSystem particleSystem2;
	public GameObject Verf;

	public Text rood;
	public Text blauw;
	public Text groen;
	public Text geel;
	public Text zwart;

	Color kleur;

	// Use this for initialization
	void Start () 
	{
		kubus = GameObject.Find ("kleur");
		snelheid = 24;

		speler = GameObject.Find ("Player/FirstPersonCharacter/Pistool");

		rood = GameObject.Find ("Canvas/Panel/Rood").GetComponent<Text>();
		blauw = GameObject.Find ("Canvas/Panel/Blauw").GetComponent<Text>();
		groen = GameObject.Find ("Canvas/Panel/Groen").GetComponent<Text>();
		geel = GameObject.Find ("Canvas/Panel/Geel").GetComponent<Text>();
		zwart = GameObject.Find ("Canvas/Panel/Zwart").GetComponent<Text>();

		rotatie = speler.transform.eulerAngles;
		transform.eulerAngles = rotatie;

		ScoreRood = PlayerPrefs.GetInt ("Rood");
		ScoreBlauw = PlayerPrefs.GetInt ("Blauw");
		ScoreGroen = PlayerPrefs.GetInt ("Groen");
		ScoreGeel = PlayerPrefs.GetInt ("Geel");
		ScoreZwart = PlayerPrefs.GetInt ("Zwart");

		kleur = GetComponent<Renderer> ().material.color = kubus.GetComponent<Renderer>().material.GetColor ("_Color");
	}
	
	// Update is called once per frame
	void Update () 
	{
		//transform.Translate (transform.forward * snelheid * Time.deltaTime );
		GetComponent<Rigidbody>().velocity =  (transform.forward * -snelheid );
	}
		
	void OnCollisionEnter(Collision col)
	{

		Instantiate (particleSystem, new Vector3 (transform.position.x, transform.position.y,  transform.position.z), Quaternion.identity);
	//	Instantiate (particleSystem2, new Vector3 (transform.position.x, transform.position.y,  transform.position.z), Quaternion.identity);
	//	Instantiate (Verf, new Vector3 (transform.position.x, transform.position.y,  transform.position.z), Quaternion.identity);
		Destroy (gameObject);

		//controleer of de bal op het vlak valt
		if (col.transform.tag == "rood" && kleur == Color.red)
		{
			ScoreRood++;

			PlayerPrefs.SetInt ("Rood", ScoreRood);

			RoodT = "1. Rood: " + ScoreRood;
			rood.text = RoodT;

			Destroy (col.gameObject);
		}

		if (col.transform.tag == "blauw" && kleur == Color.blue)
		{
			ScoreBlauw++;

			PlayerPrefs.SetInt ("Blauw", ScoreBlauw);

			BlauwT = "2. Blauw: " + ScoreBlauw;
			blauw.text = BlauwT;

			Destroy (col.gameObject);
		}

		if (col.transform.tag == "groen" && kleur == Color.green)
		{
			ScoreGroen++;

			PlayerPrefs.SetInt ("Groen", ScoreGroen);

			GroenT = "3. Groen: " + ScoreGroen;
			groen.text = GroenT;

			Destroy (col.gameObject);
		}

		if (col.transform.tag == "geel" && kleur == Color.yellow)
		{
			ScoreGeel++;

			PlayerPrefs.SetInt ("Geel", ScoreGeel);

			GeelT = "4. Geel: " + ScoreGeel;
			geel.text = GeelT;

			Destroy (col.gameObject);
		}

		if (col.transform.tag == "zwart" && kleur == Color.black)
		{
			ScoreZwart++;

			PlayerPrefs.SetInt ("Zwart", ScoreZwart);

			ZwartT = "5. Zwart: " + ScoreZwart;
			zwart.text = ZwartT;

			Destroy (col.gameObject);
		}
	}
}
