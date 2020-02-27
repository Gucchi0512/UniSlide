using System;
using UniRx;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;


[ExecuteInEditMode]
public class SlideBase : MonoBehaviour {
    [SerializeField]private Text m_TitleText;
    [SerializeField]private Image m_BGImage;

    public Text TitleText {
        get => m_TitleText;
        set => m_TitleText = value;
    }

    public Image BgImage {
        get => m_BGImage;
        set => m_BGImage = value;
    }
    
}