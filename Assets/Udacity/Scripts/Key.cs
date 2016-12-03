using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	bool looking= false;
	private AudioSource _audio_source			= null;


	[Header("Sounds")]
	public AudioClip clip_click					= null;	

	[Header("Effects")]
	public GameObject poofobject				= null;	


	void Start()
	{
		_audio_source				= gameObject.GetComponent<AudioSource>();	
		_audio_source.clip		 	= clip_click;
		_audio_source.playOnAwake 	= false;
	}

	void Update () {
		if (looking)
		{

			this.transform.Rotate(1,1,0);
		}
	}


	public void OnKeyClicked() {
		// Instantiate the CoinPoof Prefab where this coin is located
		// Make sure the poof animates vertically
		// Destroy this coin. Check the Unity documentation on how to use Destroy
		Player m_player = Camera.main.GetComponent<Player>();
		_audio_source.Play();
		if (m_player)
			m_player.set_key ();

		Instantiate (poofobject, this.transform.position,Quaternion.identity);
		gameObject.transform.localScale 									= Vector3.zero ;
	}


	public void onPointEnter()
	{

		looking = true;
	}

	public void onPointExit()
	{

		looking = false;
	}

}
