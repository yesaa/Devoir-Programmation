using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(Life))]
public class LifeEditor : Editor {

	public override void OnInspectorGUI ()
  {
    Life life = target as Life;

    life.useTime = EditorGUILayout.Toggle("Is life Timed", life.useTime);
    if(life.useTime){
      life.lifetime = EditorGUILayout.FloatField("Lifetime", life.lifetime);
    }
    life.lifePointsStart = EditorGUILayout.IntField("Start Life Points", life.lifePointsStart);
    life.lifePointsMax = EditorGUILayout.IntField("Max Life Points", life.lifePointsMax);

    if(GUI.changed){
      EditorUtility.SetDirty(target);
    }
  }
}
