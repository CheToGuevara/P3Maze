using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour {


	bool _ending = false;
	float _deltaTime = 0;
	GameObject m_camera;
	Vector3 _origin,_destiny;

	void OnTriggerEnter(Collider other) 
	{
		ParticleSystem m_partSys = this.GetComponent<ParticleSystem> ();
		if (m_partSys) 
		{
			m_partSys.Play ();
		}

		m_camera = GameObject.Find ("Main Camera");
		_origin = m_camera.transform.position;
		_destiny = m_camera.transform.position + new Vector3 (0, 10, 0);
		_ending = true;
	}


	void update()
	{
		if (_ending) {
			_deltaTime += 0.01f;
			Camera.main.transform.position = Vector3.Lerp (_origin, _destiny, _deltaTime);
			if (_deltaTime == 1)
			{
				_ending = false;
				SceneManager.LoadScene(0);
			}
		}
	}
}
