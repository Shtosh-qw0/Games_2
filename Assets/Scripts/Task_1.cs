using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Task_1 : MonoBehaviour
{
    public Vector3 coord_frame_int;
    public Vector3 coord_int;
    public Vector3 coord_frame_string;
    public Vector3 coord_string;
    public Vector3 coord_frame_bool;
    public Vector3 coord_bool;
    public Vector3 coord_frame_double;
    public Vector3 coord_double;

    public GameObject gb;
    int count = 0;
    //public Text WhateverTextThingy;
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
    }
    
    public void Click()
    {
        coord_frame_int = GameObject.Find("frame_int").transform.position;
        coord_int = GameObject.Find("int_25").transform.position;

        coord_frame_string = GameObject.Find("frame_string").transform.position;
        coord_string = GameObject.Find("string_Hello").transform.position;

        coord_frame_bool = GameObject.Find("frame_bool").transform.position;
        coord_bool = GameObject.Find("bool_true").transform.position;

        coord_frame_double = GameObject.Find("frame_double").transform.position;
        coord_double = GameObject.Find("double_14_2").transform.position;

         if (coord_frame_int == coord_int && coord_frame_string == coord_string && coord_frame_bool == coord_bool && coord_frame_double == coord_double)
         {
            Color color = new Color(
                (float)System.Convert.ToInt32("1B", 16) / 255f,
                (float)System.Convert.ToInt32("A8", 16) / 255f,
                (float)System.Convert.ToInt32("00", 16) / 255f);

            Debug.Log("Правильно");
            gb = GameObject.Find("Next");
            gb.GetComponent<Button>().interactable = true;
            count = 1;
            WhateverText.color = color;
            WhateverText.text = StrWhateverTextThingy[Random.Range(0, StrWhateverTextThingy.Length)];
            WhateverText.enabled = true;
            timeWhenDisappear = Time.time + timeToAppear;
        }

         else if (coord_frame_int != coord_int || coord_frame_string != coord_string || coord_frame_bool != coord_bool || coord_frame_double != coord_double)
         {
            Debug.Log("Не правильно");
            WhateverText.color = Color.red;
            WhateverText.text = StrWhateverTextNegative[Random.Range(0, StrWhateverTextNegative.Length)];
            WhateverText.enabled = true;
            count = 0;
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
            Click();
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

    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

