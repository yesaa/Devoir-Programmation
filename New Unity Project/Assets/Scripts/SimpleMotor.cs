using UnityEngine;
using System.Collections;

public class SimpleMotor : MonoBehaviour {

  public float speed = 5;
  //public bool useLocalDirection;
  //public Vector3 direction = Vector3.zero;

	private GameObject Player;

	void Awake()
	{
		Player = GameObject.FindGameObjectWithTag ("Player");
		transform.LookAt (transform.position + Player.transform.forward);
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