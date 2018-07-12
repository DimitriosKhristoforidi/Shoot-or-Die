using UnityEngine;

public class TriggerScript : MonoBehaviour {

	[SerializeField]
	public Light roomLight;
	[SerializeField]
	public Collider playerCollider;
	public bool IsTriggerEntered;

	void Start()
	{
		roomLight.enabled = false;
	}

	void OnTriggerEnter(Collider enteredCollider) 
	{
		if (enteredCollider.name == "Player")
		{
			roomLight.enabled = true;
			IsTriggerEntered = true;
		}
	}

	void OnTriggerExit(Collider exitedCollider)
	{
		if (exitedCollider == playerCollider)
			roomLight.enabled = false;
	}

}
