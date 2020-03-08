using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MyEditorWindow : EditorWindow
{
    [MenuItem("Window/MyEditor")]
    static void Open() {
        EditorWindow.GetWindow<MyEditorWindow>("MyEditor");
    }

    private bool toggle = false;
    private bool toggleleft;
    private string textField = "";
    private string textArea = "";
    private string password = "";
    private float horizontalScrollBar = 0.0f;
    private float verticalScrollBar = 0.0f;
    private float horizontalSlider = 0.0f;
    private float verticalSlider = 0.0f;
    private int toolBar = 0;
    private int selectionGrid = 0;

    private void OnGUI() {
        EditorGUILayout.LabelField("プレゼン資料を作れるようになるための一歩");
        //Label
        GUILayout.Label("Label: ランタイムでも使えるらしい");
        
        //Button
        if (GUILayout.Button("Button")) Debug.Log("ボタンをおしました");
        
        //RepeatButton
        if(GUILayout.RepeatButton("RepeatButton")) Debug.Log("リピートボタンが押されました");
        
        //Toggle
        toggle = GUILayout.Toggle(toggle, "toggle");
        
        //Textfield
        GUILayout.Label("TextField");
        textField = GUILayout.TextField(textField);
        
        //TextArea
        GUILayout.Label("TextArea");
        textArea = GUILayout.TextArea(textArea);
        
        //Passwordfirld
        GUILayout.Label("PasswordField");
        password = GUILayout.PasswordField(password,'*');
        
        //HorizontalScrollbar
        GUILayout.Label("HorizontalScrollbar");
        float horizontalSize = 10.0f;//バーのサイズ
        horizontalScrollBar = GUILayout.HorizontalScrollbar(horizontalScrollBar, horizontalSize, 0.0f, 100.0f);
        
        //VerticalScrollbar
        GUILayout.Label("VerticalScrollbar");
        float VerticalSize = 10.0f;//バーのサイズ
        verticalScrollBar = GUILayout.VerticalScrollbar(verticalScrollBar, VerticalSize, 0.0f, 100.0f);
        
        //HorizomtalSlider
        GUILayout.Label("HorizontalSlider");
        horizontalSlider = GUILayout.HorizontalSlider(horizontalSlider, 0.0f, 100.0f);
        
        //VerticalSlider
        GUILayout.Label("VerticalSlider");
        verticalSlider = GUILayout.VerticalSlider(verticalSlider, 0.0f, 100.0f);
        
        //ToolBar
        GUILayout.Label("Toolbar");
        toolBar = GUILayout.Toolbar(toolBar, new string[]{"toolA", "toolB", "toolC"});
        
        //SelectionGrid
        GUILayout.Label("SelectionGrid");
        selectionGrid = GUILayout.SelectionGrid(selectionGrid, new string[] {"grid1", "grid2", "grid3"},2);
        
        //Box
        GUILayout.Box("Box");
        
        //Space
        GUILayout.Label("ここからSpace");
        GUILayout.Space(100);
        GUILayout.Label("ここまで");
        
        //FlexibleSpace
        GUILayout.Label("ここからFlexibleSpace");
        GUILayout.FlexibleSpace();
        GUILayout.Label("ここまで");
    }
}
