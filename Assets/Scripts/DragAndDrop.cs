using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    private Image image;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
    }

    public void OnBeginDrag(PointerEventData eventData) // метод, который отвечает за поднятие объекта
    {
        image.color = new Color(0f, 255f, 200f, 0.7f);
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData) // метод, который отвечает за перемещение объекта
    {
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData) // метод, который отвечает за отпускание объекта
    {
        image.color = new Color(225f, 255f, 255f, 1f);
        image.raycastTarget = true;
    }
}