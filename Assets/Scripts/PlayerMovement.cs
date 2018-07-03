using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 50f;
	public float sensitivity = 2f;
	CharacterController player;

	public GameObject eyes;

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
		moveForwardBack = Input.GetAxis("Vertical") * speed;
		moveLeftRight = Input.GetAxis("Horizontal") * speed;

		rotationX = Input.GetAxis("Mouse X") * sensitivity;
		rotationY = Input.GetAxis("Mouse Y") * sensitivity;

		Vector3 movement = new Vector3(-moveForwardBack, 0, moveLeftRight);
		transform.Rotate(0, rotationX, 0);
		eyes.transform.Rotate(-rotationY, 0, 0);

		movement = transform.rotation * movement;
		player.Move(movement * Time.deltaTime);

	}

}
