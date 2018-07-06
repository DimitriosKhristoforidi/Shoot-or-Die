using UnityEngine;

public class SecondPlayerMovement : MonoBehaviour {

	public float speed = 50f;
	public float sensitivity = 2f;
	CharacterController player;

	float moveForwardBack;
	float moveLeftRight;

	float rotationX;
	float rotationY;

	void Start()
	{
		player = GetComponent<CharacterController>();
	}

	void Update()
	{
		moveForwardBack = Input.GetAxis("SecondVertical") * speed;
		moveLeftRight = Input.GetAxis("SecondHorizontal") * speed;

		rotationX = Input.GetAxis("RotateX") * sensitivity;

		Vector3 movement = new Vector3(-moveForwardBack, 0, moveLeftRight);
		transform.Rotate(0, rotationX, 0);

		movement = transform.rotation * movement;
		player.Move(movement * Time.deltaTime);

	}

}
