using UnityEngine;

public class TriggerScript : MonoBehaviour {

	[SerializeField]
	public Light roomLight;
	[SerializeField]
	public Collider playerCollider;

	void Start()
	{
		roomLight.enabled = false;
	}

	void OnTriggerEnter(Collider enteredCollider) 
	{
		if (enteredCollider == playerCollider)
		{
			roomLight.enabled = true;
		}
	}

	void OnTriggerExit(Collider exitedCollider)
	{
		if (exitedCollider == playerCollider)
			roomLight.enabled = false;
	}

}
