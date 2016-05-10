using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

  public GameObject entity;
  public float frequency = 1f;
  float timer;
  
  GameObject entityContainer;
  
  // Use this for initialization
  void Awake () {
    entityContainer = new GameObject(name+"-container");
  }

  void OnEnable(){
    spawn();
    timer = 0;
  }
  
  // spawn in late Update to wait for position calculations
  void LateUpdate () {
    
    timer += Time.deltaTime;
    if(timer > frequency){
      timer = 0;
      spawn();
    }
  }
  
  void spawn(){
    GameObject clone = (GameObject)Instantiate(entity);
    clone.transform.position  = transform.position;
    clone.transform.rotation  = transform.rotation;
    clone.transform.parent    = entityContainer.transform;
  }
}
