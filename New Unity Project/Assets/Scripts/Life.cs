using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {

  public bool useTime = false;
  public float lifetime = 10;
  float timer;

  public int lifePointsStart = 1;
  public int lifePointsMax = 100;
  int currentLifePoints;

	// Use this for initialization
	void Start () {
    currentLifePoints = lifePointsStart;
	}

  /*public void restorePoint(int nbPoints)
	{
    currentLifePoints = Mathf.Min(currentLifePoints + nbPoints, lifePointsMax);
  	}*/
	
	// Update is called once per frame
	void Update () {
    if(useTime){
      timer += Time.deltaTime;
      if(timer >= lifetime){
        kill ();
      }
    }

    if(currentLifePoints <= 0){
      kill();
    }
	}

  void OnTriggerEnter(){
    currentLifePoints--;
  }

  void kill(){
    Destroy(gameObject);
  }
}
