using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
using System;

public class Awake : MonoBehaviour
{
    public ScrollRect scrollRect;
    public TextMeshProUGUI contentText;
    string filePath;
    public TextMeshProUGUI TextMP;

    public void TTart(string nameFile)
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
    public ScrollRect scrollRect;
    public TextMeshProUGUI contentText;
    public string filePath;

    public void TTart()
    {
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
 */