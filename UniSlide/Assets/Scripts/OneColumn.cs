using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneColumn : SlideBase {
    private Text m_Column;

    public Text Column {
        get => m_Column;
        set => m_Column = value;
    }

    private void OnEnable() {
        base.Initialize();
        var canvas = base.SlideCanvas.gameObject;
        foreach (Transform child in canvas.transform) {
            if (child.gameObject.CompareTag("Column")) m_Column = child.gameObject.GetComponent<Text>();
            
        }
    }
}
