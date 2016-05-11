using UnityEngine;
using System.Collections;

public class SimpleMotor : MonoBehaviour {

  public float speed = 5;
  //public bool useLocalDirection;
  //public Vector3 direction = Vector3.zero;

	public GameObject Player;

	
	// Update is called once per frame
	void Update () 
	{
    	//if(useLocalDirection) transform.position += transform.TransformDirection(direction) * speed * Time.deltaTime;
    	//else transform.position += direction * speed * Time.deltaTime;


			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		transform.position += Player.transform.forward * speed * Time.deltaTime;
	}
}