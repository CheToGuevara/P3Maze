using UnityEngine;
using System.Collections;

public class ChangeText : MonoBehaviour {


	TextMesh _textmesh;
	// Use this for initialization
	void Start () {

		_textmesh = GetComponent<TextMesh> ();
		_textmesh.richText = true;
		_textmesh.text = "Coins: 0 <br> Key: 0";
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void UpdateText(int coins, int key)
	{
		string _text = string.Concat ("Coins: ", coins.ToString (),
			               "<br> Key: ", key.ToString ());
		_textmesh.text = _text;
	}
}
