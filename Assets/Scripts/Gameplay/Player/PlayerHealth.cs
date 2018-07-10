using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public int playerHealth = 100;
	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Enemy")
		{
			playerHealth = playerHealth - 5;
		}

		if (collisionInfo.collider.tag == "HealthUp")
		{
			Destroy(gameObject);
			playerHealth = playerHealth + 10;
		}

		if (playerHealth <= 0) 
		{
			FindObjectOfType<UIControllerScript>().GameOver();;
		}
	}

	void OnGUI()
	{
		GUI.Box(new Rect(0, 0, 100, 30), "" + playerHealth);
	}

}
