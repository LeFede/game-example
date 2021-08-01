using UnityEngine;
using System;

[CreateAssetMenu(fileName = "GameState", menuName = "States/GameState")]
public class GameState : ScriptableObject
{
    [Header("Stats")]
    public int str;
    [Range(0f,1f)]
    public float resistances;
    [Space(10)]
    public bool poisoned;
    [Tooltip("Imagine creating a custom Inspector")]
    public bool tooltip;

    [ContextMenu("Difficulty - Noob")]
    void Execute() {
        Debug.Log("Hi");
    }

}
