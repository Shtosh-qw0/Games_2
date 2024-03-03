using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Сheck : MonoBehaviour
{
    public Vector3 coord_frame_int;
    public Vector3 coord_int;
    public Vector3 coord_frame_string;
    public Vector3 coord_string;
    public Vector3 coord_frame_bool;
    public Vector3 coord_bool;
    public Vector3 coord_frmae_double;
    public Vector3 coord_double;

    public GameObject gb;

    public Text WhateverTextThingy;
    public float timeToAppear = 2f;
    private float timeWhenDisappear;

    public void Click()
    {
        coord_frame_int = GameObject.Find("frame_int").transform.position;
        coord_int = GameObject.Find("int_25").transform.position;

        coord_frame_string = GameObject.Find("frame_string").transform.position;
        coord_string = GameObject.Find("string_Hello").transform.position;

        coord_frame_bool = GameObject.Find("frame_bool").transform.position;
        coord_bool = GameObject.Find("bool_true").transform.position;

        coord_frmae_double = GameObject.Find("frame_double").transform.position;
        coord_double = GameObject.Find("double_14_2").transform.position;


        if (coord_frame_int == coord_int && coord_frame_string == coord_string && coord_frame_bool == coord_bool && coord_frmae_double == coord_double)
        {
            Debug.Log("Равны");
            gb = GameObject.Find("Next");
            gb.GetComponent<Button>().interactable = true;

            WhateverTextThingy.enabled = true;
            timeWhenDisappear = Time.time + timeToAppear;
        }

        else
        {
            Debug.Log("Не равны");
        }

    }
    void Update()
    {
        if (WhateverTextThingy.enabled && (Time.time >= timeWhenDisappear))
        {
            WhateverTextThingy.enabled = false;
        }
    }

    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
