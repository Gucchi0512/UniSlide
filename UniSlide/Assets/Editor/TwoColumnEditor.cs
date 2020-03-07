using UnityEditor;
using UnityEngine;

namespace Editor {
    [CustomEditor(typeof(TwoColumn))]
    [CanEditMultipleObjects]
    public class TwoColumnEditor : SlideEditorBase {
        public override void OnInspectorGUI() {
            base.OnInspectorGUI();
            TwoColumn twoColumn = target as TwoColumn;
            var first = twoColumn.FirstColumn;
            var second = twoColumn.SecondColumn;
            
            EditorGUILayout.LabelField("LeftColumn");
            first.text = EditorGUILayout.TextArea(first.text, GUILayout.Height(100));
            first.fontSize = EditorGUILayout.IntField("FontSize", first.fontSize);
            first.color = EditorGUILayout.ColorField("TextColor", first.color);
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("RightColumn");
            second.text = EditorGUILayout.TextArea(second.text, GUILayout.Height(100));
            second.fontSize = EditorGUILayout.IntField("FontSize", second.fontSize);
            second.color = EditorGUILayout.ColorField("TextColor", second.color);
            if(GUI.changed) EditorUtility.SetDirty(target);
        }
    }
}