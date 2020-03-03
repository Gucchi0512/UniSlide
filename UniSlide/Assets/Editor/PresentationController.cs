using System;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEngine;

namespace Editor {
    public class PresentationController : EditorWindow {

        private PresentationManager m_PManager;
        private GameObject m_MainCamera;
        private GameObject m_SlideCamera;
        [MenuItem("Window/Presentation/PresentationController")]
        private static void Open() {
            EditorWindow.GetWindow<PresentationController>("Controller");
        }
        
        private void OnEnable() {
            m_PManager = GameObject.Find("PresentationManager").GetComponent<PresentationManager>();
            m_MainCamera = GameObject.FindWithTag("MainCamera");
            m_SlideCamera = GameObject.FindWithTag("SlideCamera");
            if (m_PManager == null) Debug.LogError("Manager not found for controller");
            if (m_MainCamera == null) Debug.LogError("MainCamera not found for controller");
            if (m_SlideCamera == null) Debug.LogError("SlideCamera not found for controller");
            m_MainCamera.SetActive(false);
            m_SlideCamera.SetActive(true);
        }

        private void OnGUI() {
            EditorGUILayout.BeginHorizontal();
                if(GUILayout.Button("◀")) m_PManager.ChangeSlide(-1);
                if(GUILayout.Button("▶")) m_PManager.ChangeSlide(1);
            EditorGUILayout.EndHorizontal();
            if (GUILayout.Button("SwitchCamera")) {
                m_MainCamera.SetActive(!m_MainCamera.activeSelf);
                m_SlideCamera.SetActive(!m_SlideCamera.activeSelf);
            }
        }
    }
}