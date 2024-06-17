using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class Task_9 : MonoBehaviour
{
    public TMP_InputField InWord1;
    public TMP_InputField InWord2;
    public Vector3 coord_frame_1;
    public Vector3 coord_expression_1;
    public Vector3 coord_frame_2;
    public Vector3 coord_expression_2;
    public Vector3 coord_frame_3;
    public Vector3 coord_expression_3;

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

    public void Click_Task9()
    {
        coord_frame_1 = GameObject.Find("frame_1").transform.position;
        coord_expression_1 = GameObject.Find("expression_1").transform.position;

        coord_frame_2 = GameObject.Find("frame_2").transform.position;
        coord_expression_2 = GameObject.Find("expression_2").transform.position;

        coord_frame_3 = GameObject.Find("frame_3").transform.position;
        coord_expression_3 = GameObject.Find("expression_3").transform.position;

        string userInput1 = InWord1.text.Replace(" ", "");
        string userInput2 = InWord2.text.Replace(" ", "");

        if ((coord_frame_1 == coord_expression_1 && coord_frame_2 == coord_expression_2 && coord_frame_3 == coord_expression_3) && 
                               (userInput1 == "n>0" && userInput2 == "n<0"))
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
        // проверяет была ли нажата клавиша entr
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Click_Task9();
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
