using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneColumn : SlideBase {
    [SerializeField] private Text m_FirstColumn;

    public Text FirstColumn {
        get => m_FirstColumn;
        set => m_FirstColumn = value;
    }
}
