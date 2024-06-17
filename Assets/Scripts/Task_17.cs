using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Task_17 : MonoBehaviour
{
    public Vector3 coord_frame_1;
    public Vector3 coord_cin1;
    public Vector3 coord_cin2;
    public Vector3 coord_frame_2;
    public Vector3 coord_cout1;
    public Vector3 coord_cout2;

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

    public void Click_Task17()
    {
        coord_frame_1 = GameObject.Find("frame_1").transform.position;
        coord_frame_2 = GameObject.Find("frame_2").transform.position;
        coord_cin1 = GameObject.Find("exp_cin1").transform.position;
        coord_cin2 = GameObject.Find("exp_cin2").transform.position;
        coord_cout1 = GameObject.Find("exp_cout1").transform.position;
        coord_cout2 = GameObject.Find("exp_cout2").transform.position;

        string userInput1 = InWord1.text.Replace(" ", "");
        string userInput2 = InWord2.text.Replace(" ", "");

        if (userInput1 == "s2" && userInput2 == "s1" && ((coord_frame_1 == coord_cin1 && coord_frame_2 == coord_cout1)  
                                                        ||(coord_frame_1 == coord_cin1 && coord_frame_2 == coord_cout2)
                                                        ||(coord_frame_1 == coord_cin2 && coord_frame_2 == coord_cout1)
                                                        ||(coord_frame_1 == coord_cin2 && coord_frame_2 == coord_cout2)))
        {
            if (!InWord1.text.Contains("s2") || !InWord2.text.Contains("s1"))
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
            Click_Task17();
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
