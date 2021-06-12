using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

[CustomEditor(typeof(InformationContainer))]
public class ClearButton : Editor
{ 
    public override VisualElement CreateInspectorGUI()
    {
        
       
        return base.CreateInspectorGUI();
    }
}
