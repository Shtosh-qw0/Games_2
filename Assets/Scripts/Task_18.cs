using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Task_18 : MonoBehaviour
{
    public TMP_InputField InWord1;

    public GameObject gb;
    public Text MessageOutput;
    int count = 0;

    public float timeToAppear = 2f;
    private float timeWhenDisappear;
    [SerializeField] private Text WhateverText;
    [SerializeField] private string[] StrWhateverTextThingy;
    [SerializeField] private string[] StrWhateverTextNegative;

    private void Start()
    {
        StrWhateverTextThingy = new string[4];
        StrWhateverTextThingy[0] = "�������!";
        StrWhateverTextThingy[1] = "���������!";
        StrWhateverTextThingy[2] = "�����!";
        StrWhateverTextThingy[3] = "�������!";

        StrWhateverTextNegative = new string[4];
        StrWhateverTextNegative[0] = "�������:(";
        StrWhateverTextNegative[1] = "������� ���)";
        StrWhateverTextNegative[2] = "�����������";
        StrWhateverTextNegative[3] = "�� ������?";

        MessageOutput.enabled = false;
    }

    public void Click_Task18()
    {
        string userInput1 = InWord1.text.Replace(" ", "");

        if (userInput1 == "c!='@'")
        {
            if (!InWord1.text.Contains("!=") || !InWord1.text.Contains("'@'"))
            {
                Debug.Log("������: ����������, ������� ������ �������.");
                WhateverText.color = Color.red;
                WhateverText.text = StrWhateverTextNegative[Random.Range(0, StrWhateverTextNegative.Length)];
                WhateverText.enabled = true;
                count = 0;
                timeWhenDisappear = Time.time + timeToAppear;
            }

            else
            {
                Debug.Log("���������");
                gb = GameObject.Find("Next");
                gb.GetComponent<Button>().interactable = true;
                MessageOutput.enabled = true;
                count = 1;

                Color color = new Color(
                    (float)System.Convert.ToInt32("1B", 16) / 255f,
                    (float)System.Convert.ToInt32("A8", 16) / 255f,
                    (float)System.Convert.ToInt32("00", 16) / 255f);

                WhateverText.color = color;
                WhateverText.text = StrWhateverTextThingy[Random.Range(0, StrWhateverTextThingy.Length)];
                WhateverText.enabled = true;
                timeWhenDisappear = Time.time + timeToAppear;
            }
        }

        else
        {
            Debug.Log("�� ���������");
            WhateverText.color = Color.red;
            WhateverText.text = StrWhateverTextNegative[Random.Range(0, StrWhateverTextNegative.Length)];
            WhateverText.enabled = true;
            count = 0;
            timeWhenDisappear = Time.time + timeToAppear;
        }

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Click_Task18();
        }

        if (WhateverText.enabled && count == 1 && (Time.time >= timeWhenDisappear))
        {
            WhateverText.enabled = false;
        }

        if (WhateverText.enabled && count == 0 && (Time.time >= timeWhenDisappear))
        {
            WhateverText.enabled = false;
        }
    }
}
