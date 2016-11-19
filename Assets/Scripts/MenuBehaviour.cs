using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour {

	bool looking= false;
	public int m_scene;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (looking)
		{
			
			this.transform.Rotate(0,1,0);
		}
	}



	public void onPointEnter()
	{
		
		looking = true;
	}

	public void onPointExit()
	{
		
		looking = false;
	}

	public void onPointClicked()
	{
		SceneManager.LoadScene(m_scene);
	}
}
