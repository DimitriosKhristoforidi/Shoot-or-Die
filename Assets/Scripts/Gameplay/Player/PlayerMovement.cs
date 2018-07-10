using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {

	public float speed = 50f;
	CharacterController player;

	float moveForwardBack;
	float moveLeftRight;

	void Start()
	{
		player = GetComponent<CharacterController>();
	}

	void Update()
	{
		moveForwardBack = CrossPlatformInputManager.GetAxis("Vertical") * speed;
		moveLeftRight = CrossPlatformInputManager.GetAxis("Horizontal") * speed;

		Vector3 movement = new Vector3(-moveForwardBack, 0, moveLeftRight);
		player.Move(movement * Time.deltaTime);


	}


}
