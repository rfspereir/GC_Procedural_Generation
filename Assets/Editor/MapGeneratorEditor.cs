using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;



[CustomEditor (typeof(MapGenerator))]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI(){
        MapGenerator mapGen = (MapGenerator)target;
        MapDisplay display = FindObjectOfType<MapDisplay>();

        if (DrawDefaultInspector()){
            if (mapGen.autoUpdate){
                mapGen.GenerateMap();
            }
        }

        if (GUILayout.Button ("Generate")){
            mapGen.GenerateMap();
        }
        if (GUILayout.Button ("Erase")){
           display.ClearDisplay();
        }
    }
}
