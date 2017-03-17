using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdateRood : MonoBehaviour
{
	public Text text;

	public void UpdateRood(string f)
	{
		text.text = f;
	}
}
