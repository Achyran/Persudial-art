using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(HousGenerator))]
public class HouseGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        HousGenerator gen = (HousGenerator)target;

        if (GUILayout.Button("Generate!"))
        {
            gen.SpawHouse();
        }
    }
}
