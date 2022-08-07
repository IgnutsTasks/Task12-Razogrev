using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private float changeDelay = 1f;
    [SerializeField] private string[] texts;

    private int _currentIndex = 0;
    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(ChangeText), 0, changeDelay);
    }

    private void ChangeText()
    {
        _text.text = texts[_currentIndex];

        _currentIndex++;
        if (_currentIndex == texts.Length)
        {
            _currentIndex = 0;
        }
    }
}
