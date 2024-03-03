using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData) // метод, который позволяет хранить в себе объекты
    {
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }

    public void OnTriggerEnter2D(Collider2D frame_int)
    {
        if (frame_int.CompareTag("int_25")) // Проверяем, что объект находится в слоте
        {
            Debug.Log("+");// Действия, которые нужно выполнить, если объект лежит в слоте
        }
    }
}
