using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(TGMap))]
public class TGMapInspector : Editor {

	public override void OnInspectorGUI () {
		base.OnInspectorGUI ();

		if (GUILayout.Button ("Regenerate")) {
			TGMap tileMap = (TGMap)target;
			tileMap.BuildMesh ();
		}
	}
}
