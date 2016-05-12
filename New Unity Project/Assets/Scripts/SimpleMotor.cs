using UnityEngine;
using System.Collections;

public class SimpleMotor : MonoBehaviour {

  public float speed = 5;
  //public bool useLocalDirection;
  //public Vector3 direction = Vector3.zero;

	private GameObject camera;

	void Awake()
	{
		camera = GameObject.FindGameObjectWithTag ("MainCamera");
		transform.LookAt (transform.position + camera.transform.forward);
	}
	
	// Update is called once per frame
	void Update () 
	{

		transform.position += transform.forward * speed;
	}

	/*void OnTriggerEnter(Collider _coll)
	{
		if (_coll.GetComponent<Life>)
			currentLifePoints--;
	}*/
}