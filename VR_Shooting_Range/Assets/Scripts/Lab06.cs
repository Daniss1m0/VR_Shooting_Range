using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Lab06 : MonoBehaviour
{
    public Slider slider;
    public TMP_Text namesText;
    public Button addButton;
    public Button removeButton;

    private string textImion;

    void Start()
    {
        addButton.onClick.AddListener(Dodaj);
        removeButton.onClick.AddListener(Usun);
        textImion = namesText.text;
    }


    void Dodaj()
    {
        string sliderValue = slider.value.ToString();
        namesText.text += sliderValue + "\n";
    }

    void Usun()
    {
        string[] lines = namesText.text.Trim().Split('\n');

        if (lines.Length > 1)
            namesText.text = string.Join("\n", lines, 0, lines.Length - 1);
        else
            namesText.text = "";
    }

}