using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData) // �����, ������� ��������� ������� � ���� �������
    {
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }

    public void OnTriggerEnter2D(Collider2D frame_int)
    {
        if (frame_int.CompareTag("int_25")) // ���������, ��� ������ ��������� � �����
        {
            Debug.Log("+");// ��������, ������� ����� ���������, ���� ������ ����� � �����
        }
    }
}
