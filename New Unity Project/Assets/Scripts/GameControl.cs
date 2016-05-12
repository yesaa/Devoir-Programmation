using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary; //unreadable
using System.IO;

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


		PlayerPrefs.SetString ("PlayerState", "life = 10");

		string _playerstate = PlayerPrefs.GetString ("PlayerState");

	}

	void OnGUI()
	{
		GUI.Label(new Rect(10,10,100,30), "Health: " + health);
	}

	/*public void Save()
	{
		BinaryFormatter bf = new BinaryFormatter;
		FileStream file = File.Create(Application.persistentDataPath+"/playerInfo.dat");

		PlayerData data = new PlayerData();
		data.health=health;

		bf Serialize(File, data);
		file.Close();
	}

	public void Load()
	{
		if (File.Exists(Application.persistentDataPath+"/playerInfo.dat"))
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath+"/playerInfo.dat", FileMode.Open);
			PlayerData data = bf.Deserialize(file);

			health = data.health;
		}
	}*/

	[Serializable]
	class PlayerData
	{
		public float health;
	}

}
