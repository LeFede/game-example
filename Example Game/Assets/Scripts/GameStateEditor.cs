using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GameState))] 
public class GameStateEditor : Editor
{
    
    public override void OnInspectorGUI() {

        GameState gameState = (GameState) target;
        base.DrawDefaultInspector();

        if (GUILayout.Button("Increase str")) {
            gameState.str++;
        }
        // GUILayout.Space(20f);
        // GUILayout.Label("Custom Editor Elements", EditorStyles.boldLabel);

        // GUILayout.Space(10f);
        // GUILayout.Label("Player Preferences");
        //base.DrawDefaultInspector();

        // GUILayout.BeginHorizontal();
        // GUILayout.Label("Player Level", GUILayout.Width(30f));
       
        // GUILayout.EndHorizontal();
    }
}
