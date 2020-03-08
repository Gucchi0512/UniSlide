using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoColumn : SlideBase{
    private Text m_FirstColumn;
    private Text m_SecondColumn;
    
    public Text FirstColumn {
        get => m_FirstColumn;
        set => m_FirstColumn = value;
    }

    public Text SecondColumn {
        get => m_SecondColumn;
        set => m_SecondColumn = value;
    }

    private void OnEnable() {
        base.Initialize();
        var canvas = base.SlideCanvas.gameObject;
        foreach (Transform child in canvas.transform) {
            if (child.gameObject.CompareTag("Column")) {
                if (m_FirstColumn == null) m_FirstColumn = child.gameObject.GetComponent<Text>();
                else if (m_SecondColumn == null) m_SecondColumn = child.gameObject.GetComponent<Text>();
            }
        }
    }
}
