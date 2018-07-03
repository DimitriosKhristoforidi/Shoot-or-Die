using UnityEngine;

public class GunScript : MonoBehaviour {

	public float damage = 10f;
	public float range = 100f;
	public float impactForce = 100f;

	public Camera fpsCam;
	public GameObject impactEffect;
	 
	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Shoot();
		}	
	}

	public void Shoot()
	{
		RaycastHit hit;
		if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
		{
			Debug.Log(hit.transform.name);
			TargetScript target = hit.transform.GetComponent<TargetScript>();
			if (target != null) 
			{
				target.TakeDamage(damage);
			}

			if (hit.rigidbody != null) 
			{
				hit.rigidbody.AddForce(-hit.normal * impactForce);
			}

			GameObject impactGameObject = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
			Destroy(impactGameObject, 0.15f);
		}
	}


}
