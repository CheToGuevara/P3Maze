using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	bool key_found = false;
	int coins = 0;




	public void set_key(bool found)
	{
		key_found = found;
	}

	public bool get_key()
	{
		return key_found;
	}

	public void add_coin()
	{
		coins++;
	}

	public int get_coins()
	{
		return coins;
	}

}
