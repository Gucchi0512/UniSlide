using System;
using UniRx;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;


[ExecuteInEditMode]
public class SlideBase : MonoBehaviour {
    private Canvas m_SlideCanvas;
    private Text m_TitleText;
    private Image m_BGImage;

    public Text TitleText {
        get => m_TitleText;
        set => m_TitleText = value;
    }

    public Image BgImage {
        get => m_BGImage;
        set => m_BGImage = value;
    }

    private void OnEnable() {
        foreach (Transform child in transform) {
            var tag = child.gameObject.tag;
            switch (tag) {
                case "SlideCanvas":
                    m_SlideCanvas = child.gameObject.GetComponent<Canvas>();
                    m_SlideCanvas.worldCamera = GameObject.FindWithTag("SlideCamera").GetComponent<Camera>();
                    break;
                case "TitleText":
                    m_TitleText = child.gameObject.GetComponent<Text>();
                    break;
                case "BGImage" :
                    m_BGImage = child.gameObject.GetComponent<Image>();
                    break;
                default:
                    break;
            }
        }
    }
}