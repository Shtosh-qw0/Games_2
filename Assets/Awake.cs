using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class DynamicScrollViewContent : MonoBehaviour
{
    public ScrollRect scrollRect;
    public Text contentText;
    public string filePath;

    void TTart()
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
