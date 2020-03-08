using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleSlide : SlideBase {
    private Text m_PresenterName;

    public Text PresenterName {
        get => m_PresenterName;
        set => m_PresenterName = value;
    }

    private void OnEnable() {
        base.Initialize();
        var canvas = base.SlideCanvas.gameObject;
        foreach (Transform child in canvas.transform) {
            if (child.gameObject.CompareTag("PresenterName")) m_PresenterName = child.gameObject.GetComponent<Text>();
        }
    }
}
