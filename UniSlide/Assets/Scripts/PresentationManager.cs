using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class PresentationManager : MonoBehaviour {
    static public PresentationManager instance;
    [SerializeField] private GameObject m_Slides;
    private int m_CurrentSlide = 0;
    private int m_SlideNum = 0;
    public GameObject Slides {
        get => m_Slides;
        set => m_Slides = value;
    }

    public int CurrentSlide {
        get => m_CurrentSlide;
        set => m_CurrentSlide = value;
    }

    private void Start() {
        for (int count = 1; count < m_SlideNum; count++) {
            m_Slides.transform.GetChild(count).gameObject.SetActive(false);
        }
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) ChangeSlide(-1);
        if (Input.GetKeyDown(KeyCode.RightArrow)) ChangeSlide(1);
        
    }

    public void ChangeSlide(int control) {
        int nextSlide = m_CurrentSlide + control;
        if (nextSlide >= 0 && nextSlide < m_Slides.transform.childCount) {
            m_Slides.transform.GetChild(m_CurrentSlide).gameObject.SetActive(false);
            m_Slides.transform.GetChild(nextSlide).gameObject.SetActive(true);
            m_CurrentSlide = nextSlide;
        }
        
    }
}
