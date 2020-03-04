using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Editor;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using Object = UnityEngine.Object;


public class CreateSlide : EditorWindow {
    
    static private PresentationManager m_PManager;
    private string[] m_SlideTypes = new string[] {
        "TitleSlide",
        "OneColumnSlide"
    };
    private string m_Slidename = "Slide:P";
    [SerializeField] private Object m_PreviewDirectory;
    private string directoryPath;
    private int selectedIndex = 0;
    private void OnEnable() {
        directoryPath = AssetDatabase.GetAssetPath(m_PreviewDirectory);
    }

    [MenuItem("Window/Presentation/CreateSlide")]
    static void Open() {
        EditorWindow.GetWindow<CreateSlide>("CreateSlide");
        GameObject obj = GameObject.Find("PresentationManager");
        if (obj == null) {
            var manager = new GameObject("PresentationManager");
            var preMan = manager.AddComponent<PresentationManager>();
            var slides = new GameObject("Slides");
            slides.transform.parent = manager.transform;
            preMan.Slides = slides;
            m_PManager = preMan;
        } else {
            m_PManager = obj.GetComponent<PresentationManager>();
        }
        m_PManager.CurrentSlide = m_PManager.Slides.transform.childCount - 1;
        GameObject cam = GameObject.FindWithTag("SlideCamera");
        if (cam == null) {
            cam = Resources.Load("SlideCamera") as GameObject;
            cam = Instantiate(cam);
        }
    }

    private void OnGUI() {
        int slideCount = m_PManager.Slides.transform.childCount;
        int currentSlide = m_PManager.CurrentSlide;
        
        selectedIndex = EditorGUILayout.Popup("SlideType", selectedIndex, m_SlideTypes);
        var slide = Resources.Load("SlidePrefabs/" + m_SlideTypes[selectedIndex]) as GameObject;
        string[] name = Directory.GetFiles(directoryPath, slide.name + ".png");
        Texture2D preview = AssetDatabase.LoadAssetAtPath(name[0], typeof(Texture2D)) as Texture2D;
        if (GUILayout.Button("Create New Slide")) {
            var obj = Instantiate(slide);
            obj.name = m_Slidename + slideCount;
            obj.transform.parent = m_PManager.Slides.transform;
            Undo.RegisterCreatedObjectUndo(obj, "Create New Slide");
            if (slideCount != 0) {
                m_PManager.Slides.transform.GetChild(currentSlide).gameObject.SetActive(false);
                m_PManager.CurrentSlide = currentSlide+1;
            }
        }
        GUILayout.Label("Slide Preview");
        EditorGUI.DrawPreviewTexture(new Rect(10, 70, 512, 384), preview);
    }
}
