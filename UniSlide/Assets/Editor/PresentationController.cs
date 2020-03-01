using System;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEngine;

namespace Editor {
    public class PresentationController : EditorWindow {

        private PresentationManager m_PManager;
        [MenuItem("Window/Presentation/PresentationController")]
        private static void Open() {
            EditorWindow.GetWindow<PresentationController>();
        }
        
        private void OnEnable() {
            m_PManager = GameObject.Find("PresentationManager").GetComponent<PresentationManager>();
            if (m_PManager == null) Debug.LogError("Manager not found in controller");
        }

        private void OnGUI() {
            EditorGUILayout.BeginHorizontal();
                if(GUILayout.Button("◀")) m_PManager.ChangeSlide(-1);
                if(GUILayout.Button("▶")) m_PManager.ChangeSlide(1);
            EditorGUILayout.EndHorizontal();    
        }
    }
}