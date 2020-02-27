using UnityEditor;
using UnityEngine;

namespace Editor {
    [CustomEditor(typeof(TitleSlide))]
    public class TitleSlideEditor : SlideEditorBase {
        public override void OnInspectorGUI() {
            base.OnInspectorGUI();
            TitleSlide slide = target as TitleSlide;
            var presenterName = slide.PresenterName;
            EditorGUILayout.LabelField("PresenterName");
            presenterName.text = EditorGUILayout.TextArea(presenterName.text, GUILayout.Height(50));
            presenterName.fontSize = EditorGUILayout.IntField("FontSize", presenterName.fontSize);
            presenterName.color = EditorGUILayout.ColorField("TextColor", presenterName.color);
            if(GUI.changed) EditorUtility.SetDirty(target);
        }
    }
}