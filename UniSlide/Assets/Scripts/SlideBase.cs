using System;
using System.Diagnostics;
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

    protected void Initialize() {
        m_SlideCanvas = this.transform.GetChild(0).GetComponent<Canvas>();
        m_SlideCanvas.worldCamera = GameObject.FindWithTag("SlideCamera").GetComponent<Camera>();
        var canvas = m_SlideCanvas.gameObject;
        foreach (Transform child in canvas.transform) {
            switch (child.tag) {
                case "BGImage":
                    m_BGImage = child.gameObject.GetComponent<Image>();
                    break;
                case "TitleText":
                    m_TitleText = child.gameObject.GetComponent<Text>();
                    break;
                default:
                    break;
            }
        }
    } 
}