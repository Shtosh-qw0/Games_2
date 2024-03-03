using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System;
using TMPro;

public class TextUI : MonoBehaviour
{
    public ScrollRect scrollRect;
    public TextMeshProUGUI contentText;
    string filePath;
    public TextMeshProUGUI TextMP;

    public void Click(string nameFile)
    {
        //        TextMP.text = "";
        filePath = @"C:\Users\Анна\Desktop\Unity\Games_2\Assets\TextMesh Pro\Resources\Books\" + nameFile + ".txt";
        string fileContent = File.ReadAllText(filePath);
        contentText.text = fileContent;

        // Установка размера контента ScrollView на основе содержимого
        RectTransform contentTransform = contentText.GetComponent<RectTransform>();
        contentTransform.sizeDelta = new Vector2(contentTransform.sizeDelta.x, contentText.preferredHeight);

        // Обновление размеров ScrollView
        Canvas.ForceUpdateCanvases();
        scrollRect.normalizedPosition = new Vector2(0, 1);



    }
}



/*
 {
    public TextMeshProUGUI TextMP;

    public void Click(string nameFile)
    {
        TextMP.text = "";

        StreamReader sr = new StreamReader(@"C:\Users\Анна\Desktop\Unity\Games_2\Assets\TextMesh Pro\Resources\Books\" + nameFile + ".txt");

        string line = "";

        while ((line = sr.ReadLine()) != null)
        {

            TextMP.text += line + Environment.NewLine;
        }
    }
}
 */