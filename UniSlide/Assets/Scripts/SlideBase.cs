using System;
using UniRx;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;


[ExecuteInEditMode]
public class SlideBase : MonoBehaviour {
    [SerializeField]private Canvas m_SlideCanvas;
    [SerializeField]private Text m_TitleText;
    [SerializeField]private Image m_BGImage;

    public Canvas SlideCanvas {
        get => m_SlideCanvas;
        set => m_SlideCanvas = value;
    }

    public Text TitleText {
        get => m_TitleText;
        set => m_TitleText = value;
    }

    public Image BgImage {
        get => m_BGImage;
        set => m_BGImage = value;
    }

    private void OnEnable() {
        m_SlideCanvas.worldCamera = GameObject.FindWithTag("SlideCamera").GetComponent<Camera>();
    }

    
}