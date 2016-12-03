using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	bool opening= false;
	private AudioSource _audio_source			= null;
	float _time=0;


	[Header("Sounds")]
	public AudioClip clip_lock					= null;	
	public AudioClip clip_open					= null;	


	void Start()
	{
		_audio_source				= gameObject.GetComponent<AudioSource>();	
		_audio_source.clip		 	= clip_lock;
		_audio_source.playOnAwake 	= false;
	}

	void Update () {
		if (opening)
		{
			_audio_source.Play ();
			_time += 0.001f;
			this.transform.rotation = Quaternion.Lerp(
				Quaternion.Euler(0,0,0),
				Quaternion.Euler(0,90,0),_time);
		}
	}


	public void OnDoorClicked() {
		// Instantiate the CoinPoof Prefab where this coin is located
		// Make sure the poof animates vertically
		// Destroy this coin. Check the Unity documentation on how to use Destroy
		Player m_player = Camera.main.GetComponent<Player> ();
		_audio_source.Play ();
		if (m_player)
		if (m_player.get_key () > 0) {
			_audio_source.clip		 	= clip_open;
			_audio_source.loop 			= true;
			opening = true;
		} else {
			_audio_source.clip		 	= clip_lock;
		}


	}


	public void onPointEnter()
	{


	}

	public void onPointExit()
	{


	}
}
