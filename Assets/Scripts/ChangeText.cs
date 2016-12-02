using UnityEngine;
using System.Collections;

public class ChangeText : MonoBehaviour {


	TextMesh _textmesh;
	// Use this for initialization
	void Start () {

		_textmesh = GetComponent<TextMesh> ();
		_textmesh.richText = true;
		_textmesh.text = "Coins: 0 \nKey: 0 \nDoor Close";
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void UpdateText(int coins, int key)
	{
		string _text = string.Concat ("Coins: ", coins.ToString (),
			"\n Key: ", key.ToString (), "\n Door",(key>0)?"Open":"Close");
		_textmesh.text = _text;
	}
}
