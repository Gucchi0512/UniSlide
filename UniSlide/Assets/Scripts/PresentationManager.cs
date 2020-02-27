using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class PresentationManager : MonoBehaviour {
    static public PresentationManager instance;
    [SerializeField] private GameObject m_Slides;
    private int m_currentSlide = 0;
    private int m_slideNum = 0;
    public GameObject Slides {
        get => m_Slides;
        set => m_Slides = value;
    }

    private void Start() {
        m_slideNum = m_Slides.transform.childCount;
        for (int count = 1; count < m_slideNum; count++) {
            m_Slides.transform.GetChild(count).gameObject.SetActive(false);
        }
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) ChangeSlide(-1);
        if (Input.GetKeyDown(KeyCode.RightArrow)) ChangeSlide(1);
        
    }

    private void ChangeSlide(int control) {
        int nextSlide = m_currentSlide + control;
        if (nextSlide >= 0 && nextSlide < m_slideNum) {
            m_Slides.transform.GetChild(m_currentSlide).gameObject.SetActive(false);
            m_Slides.transform.GetChild(nextSlide).gameObject.SetActive(true);
            m_currentSlide = nextSlide;
        }
        
    }
}
