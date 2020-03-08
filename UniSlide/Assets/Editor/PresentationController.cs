using System;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEngine;

namespace Editor {
    public class PresentationController : EditorWindow {

        private PresentationManager m_PManager;
        private GameObject m_MainCamera;
        private GameObject m_SlideCamera;
        private void OnEnable() {
            m_PManager = GameObject.Find("PresentationManager").GetComponent<PresentationManager>();
            m_MainCamera = GameObject.FindWithTag("MainCamera");
            m_SlideCamera = GameObject.FindWithTag("SlideCamera");
            if (m_PManager == null) Debug.LogError("Manager not found for controller");
            if (m_MainCamera == null) Debug.LogError("MainCamera not found for controller");
            if (m_SlideCamera == null) Debug.LogError("SlideCamera not found for controller");
            m_MainCamera.GetComponent<Camera>().enabled = false;
            m_SlideCamera.GetComponent<Camera>().enabled = true;
        }

        private void OnGUI() {
            EditorGUILayout.BeginHorizontal();
                if(GUILayout.Button("Prev")) m_PManager.ChangeSlide(-1);
                if(GUILayout.Button("Next")) m_PManager.ChangeSlide(1);
            EditorGUILayout.EndHorizontal();
            if (GUILayout.Button("SwitchCamera")) {
                var maincam = m_MainCamera.GetComponent<Camera>();
                var slidecam = m_SlideCamera.GetComponent<Camera>();
                maincam.enabled = !maincam.enabled;
                slidecam.enabled = !slidecam.enabled;
            }
        }

    }
}