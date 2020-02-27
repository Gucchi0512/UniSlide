using UnityEditor;
using UnityEngine;

namespace Editor {
    [CustomEditor(typeof(OneColumn),true)]
    public class OneColumnEditor : SlideEditorBase {
        
        public override void OnInspectorGUI() {
            base.OnInspectorGUI();
            OneColumn slide = target as OneColumn;
            var firstColumn = slide.FirstColumn;

            EditorGUILayout.LabelField("FirstColumn");
            firstColumn.text = EditorGUILayout.TextArea(firstColumn.text, GUILayout.Height(100));
            firstColumn.fontSize = EditorGUILayout.IntField("FontSize", firstColumn.fontSize);
            firstColumn.color = EditorGUILayout.ColorField("TextColor", firstColumn.color);
            if(GUI.changed) EditorUtility.SetDirty(target);
        }
    }
}