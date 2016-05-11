using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bullet;


	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0))
			Instantiate (bullet, transform.position, Quaternion.identity);
	}
}