using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public int playerHealth = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OncollisionEnter(Collision enemy)
	{
		if (enemy.gameObject.tag == "Enemy")
		{
			playerHealth -= 5;		
		}
	}

	void OnGUI()
	{
		GUI.Box(new Rect(0, 0, 100, 30), "Health = " + playerHealth);
	}
}
