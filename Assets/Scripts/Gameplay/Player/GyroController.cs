using UnityEngine;

public class GyroController : MonoBehaviour {

	private bool isGyroEnabled;
	private Gyroscope playerGyroscope;

	private GameObject cameraContainer;
	public Quaternion cameraRotation;

	void Start () 
	{
		cameraContainer = new GameObject("Camera Container");
		cameraContainer.transform.position = transform.position;
		transform.SetParent(cameraContainer.transform);

		isGyroEnabled = EnableGyroscope();
	}


	void Update () {

		if (isGyroEnabled) 
		{
			transform.localRotation = playerGyroscope.attitude * cameraRotation;
		}
	}

	private bool EnableGyroscope()
	{
		if (SystemInfo.supportsGyroscope)
		{
			playerGyroscope = Input.gyro;
			playerGyroscope.enabled = true;

			cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
			cameraRotation = new Quaternion(0, 0, 1, 0);

			return true;
		}
		return false;
	}
}
