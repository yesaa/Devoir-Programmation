using UnityEngine;
using System.Collections;

public class SeekTarget : MonoBehaviour {

  public Transform target;
  public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    Vector3 dir = target.position - transform.position;
    transform.position += dir.normalized * speed;
	}
}
