using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Task_8 : MonoBehaviour
{
    public TMP_InputField InWord1;
    public TMP_InputField InWord2;
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
        StrWhateverTextThingy[0] = "Молодец!";
        StrWhateverTextThingy[1] = "Правильно!";
        StrWhateverTextThingy[2] = "Супер!";
        StrWhateverTextThingy[3] = "Отлично!";

        StrWhateverTextNegative = new string[4];
        StrWhateverTextNegative[0] = "Неверно:(";
        StrWhateverTextNegative[1] = "Подумай ещё)";
        StrWhateverTextNegative[2] = "Неправильно";
        StrWhateverTextNegative[3] = "Ты уверен?";

        MessageOutput.enabled = false;

    }

    public void CheckingInputWord()
    {
        string userInput1 = InWord1.text.Replace(" ", "");
        string userInput2 = InWord2.text.Replace(" ", "");

        if (userInput1 == "if(a<b)" && userInput2 == "else")
        {
            if (!InWord1.text.Contains("if") || !InWord2.text.Contains("else"))
            {
                Debug.Log("Ошибка: Пожалуйста, уберите лишнии пробелы.");
                WhateverText.color = Color.red;
                WhateverText.text = StrWhateverTextNegative[Random.Range(0, StrWhateverTextNegative.Length)];
                WhateverText.enabled = true;
                count = 0;
                timeWhenDisappear = Time.time + timeToAppear;
            }

            else
            {
                Debug.Log("Правильно");
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
            Debug.Log("Не правильно");
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
            CheckingInputWord();
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
