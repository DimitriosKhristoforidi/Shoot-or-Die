﻿using UnityEngine;

public class TargetScript : MonoBehaviour
{
	public float health = 100f;

	public void TakeDamage(float amount) 
	{
		health -= amount;
		if (health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		Destroy(gameObject);
	}
}
