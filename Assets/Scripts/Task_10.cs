using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Task_10 : MonoBehaviour
{
    public Vector3 coord_frame_1;
    public Vector3 coord_frame_2;
    public Vector3 coord_frame_3;

    public Vector3 coord_and_1;
    public Vector3 coord_and_2;
    public Vector3 coord_and_3;
    public Vector3 coord_or_1;
    public Vector3 coord_or_2;
    public Vector3 coord_or_3;

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

    public void Click_Task10()
    {
        coord_frame_1 = GameObject.Find("frame_1").transform.position;
        coord_and_1 = GameObject.Find("and_1").transform.position;
        coord_or_1 = GameObject.Find("or_1").transform.position;

        coord_frame_2 = GameObject.Find("frame_2").transform.position;
        coord_and_2 = GameObject.Find("and_2").transform.position;
        coord_or_2 = GameObject.Find("or_2").transform.position;

        coord_frame_3 = GameObject.Find("frame_3").transform.position;
        coord_and_3 = GameObject.Find("and_3").transform.position;
        coord_or_3 = GameObject.Find("or_3").transform.position;

        if ((coord_frame_1 == coord_and_1 && coord_frame_2 == coord_or_1 && coord_frame_3 == coord_or_2)
                    || (coord_frame_1 == coord_and_1 && coord_frame_2 == coord_or_1 && coord_frame_3 == coord_or_3)
                    || (coord_frame_1 == coord_and_1 && coord_frame_2 == coord_or_2 && coord_frame_3 == coord_or_1)
                    || (coord_frame_1 == coord_and_1 && coord_frame_2 == coord_or_2 && coord_frame_3 == coord_or_3)
                    || (coord_frame_1 == coord_and_1 && coord_frame_2 == coord_or_3 && coord_frame_3 == coord_or_1)
                    || (coord_frame_1 == coord_and_1 && coord_frame_2 == coord_or_3 && coord_frame_3 == coord_or_2)

                    || (coord_frame_1 == coord_and_2 && coord_frame_2 == coord_or_1 && coord_frame_3 == coord_or_2)
                    || (coord_frame_1 == coord_and_2 && coord_frame_2 == coord_or_1 && coord_frame_3 == coord_or_3)
                    || (coord_frame_1 == coord_and_2 && coord_frame_2 == coord_or_2 && coord_frame_3 == coord_or_1)
                    || (coord_frame_1 == coord_and_2 && coord_frame_2 == coord_or_2 && coord_frame_3 == coord_or_3)
                    || (coord_frame_1 == coord_and_2 && coord_frame_2 == coord_or_3 && coord_frame_3 == coord_or_1)
                    || (coord_frame_1 == coord_and_2 && coord_frame_2 == coord_or_3 && coord_frame_3 == coord_or_2)

                    || (coord_frame_1 == coord_and_3 && coord_frame_2 == coord_or_1 && coord_frame_3 == coord_or_2)
                    || (coord_frame_1 == coord_and_3 && coord_frame_2 == coord_or_1 && coord_frame_3 == coord_or_3)
                    || (coord_frame_1 == coord_and_3 && coord_frame_2 == coord_or_2 && coord_frame_3 == coord_or_1)
                    || (coord_frame_1 == coord_and_3 && coord_frame_2 == coord_or_2 && coord_frame_3 == coord_or_3)
                    || (coord_frame_1 == coord_and_3 && coord_frame_2 == coord_or_3 && coord_frame_3 == coord_or_1)
                    || (coord_frame_1 == coord_and_3 && coord_frame_2 == coord_or_3 && coord_frame_3 == coord_or_2))
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
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Click_Task10();
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
