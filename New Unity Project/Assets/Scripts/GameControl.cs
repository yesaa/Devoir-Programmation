using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	public float health;
	public static GameControl control;

	// Use this for initialization
	void Awake () 
	{
		Cursor.visible = false;

		if (control == null) 
		{
			DontDestroyOnLoad (gameObject);
			control = this;
		} 
		else if (control != this)
			Destroy (gameObject);
	}

	void Update ()
	{
		if (Input.GetKey("space"))
			Cursor.visible = true;
	}

	void OnGUI()
	{
		GUI.Label(new Rect(10,10,100,30), "Health: " + health);
	}

}
