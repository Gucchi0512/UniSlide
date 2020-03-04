using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleSlide : SlideBase {
    [SerializeField] private Text m_PresenterName;

    public Text PresenterName {
        get => m_PresenterName;
        set => m_PresenterName = value;
    }

    
}
