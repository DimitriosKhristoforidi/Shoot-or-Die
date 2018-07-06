using UnityEngine;

public class EnemyScript : MonoBehaviour
{
	public float health = 100f;
	public Transform enemyTarget;
	UnityEngine.AI.NavMeshAgent navMeshAgent;

	void Start()
	{
		navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}

	void Update()
	{
		navMeshAgent.SetDestination(enemyTarget.position);
	}

	public void TakeDamage(float amount)
	{
		health -= amount;
		if (health <= 0)
		{
            Destroy(gameObject);
		}
	}


}
