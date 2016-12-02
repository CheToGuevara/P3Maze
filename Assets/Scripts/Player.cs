using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	int key_found = 0;
	int coins = 0;

	[Header("Text")]
	public ChangeText _walltext;

	[Header("Speed travel")]
	[Range(0.0001f,1)] public float speed		=0.0001f;


	private Vector3		_origin					= new Vector3(0,0,0);
	private Vector3		_destiny				= new Vector3(0,0,0);
	private bool 		_ending					= false;
	private float 		_deltaTime 				= 0.0f;

	public void set_key()
	{
		key_found++;
		UpdateWall ();
	}

	public int get_key()
	{
		return key_found;
	}

	public void add_coin()
	{
		coins++;
		UpdateWall ();
	}

	public int get_coins()
	{
		return coins;
	}

	void UpdateWall(){
		_walltext.UpdateText (coins, key_found);
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Fin");

		_origin = Camera.main.transform.position;
		Debug.Log (_origin);
		_destiny = _origin + new Vector3(0,10,0);
		Debug.Log (_destiny);
		_ending = true;

	}


	void Update()
	{
		if (_ending) 
		{

			_deltaTime += speed;
			this.transform.Translate(0,speed,0);
			//Debug.Log (Vector3.Lerp (_origin,_destiny,_deltaTime));
			if (_deltaTime > 1)
				SceneManager.LoadScene (0);
		}
	}

}
