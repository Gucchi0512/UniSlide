using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SlideBase), true)]
[CanEditMultipleObjects]
public class SlideEditorBase : UnityEditor.Editor {
    
    public override void OnInspectorGUI() {
        SlideBase slide = target as SlideBase;
        var titleText = slide.TitleText;
        slide.BgImage.sprite = EditorGUILayout.ObjectField("BackGroundImage", slide.BgImage.sprite, typeof(Sprite), true) as Sprite;
        
        EditorGUILayout.LabelField("Title Text");
        titleText.text = EditorGUILayout.TextField("Text", slide.TitleText.text);
        titleText.fontSize = EditorGUILayout.IntField("FontSize", titleText.fontSize);
        titleText.color = EditorGUILayout.ColorField("TextColor", titleText.color);
        EditorGUILayout.Space();
        if(GUI.changed)EditorUtility.SetDirty(target);
    }
}
