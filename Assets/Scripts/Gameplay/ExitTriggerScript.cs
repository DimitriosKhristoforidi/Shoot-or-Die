using UnityEngine;

public class ExitTriggerScript : MonoBehaviour {

	[SerializeField]
	public Collider playerCollider;

	private void OnTriggerEnter(Collider other)
	{
		if (other == playerCollider)
			FindObjectOfType<UIControllerScript>().Win();
	}
}
