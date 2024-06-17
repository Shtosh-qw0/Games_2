using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Сheck : MonoBehaviour
{
    // было для 1 задания
    public Vector3 coord_frame_int;
    public Vector3 coord_int;
    public Vector3 coord_frame_string;
    public Vector3 coord_string;
    public Vector3 coord_frame_bool;
    public Vector3 coord_bool;
    public Vector3 coord_frame_double;
    public Vector3 coord_double;
    public Vector3 values;

    public GameObject gb;

    public Text WhateverTextThingy;
    public float timeToAppear = 2f;
    private float timeWhenDisappear;
    //[SerializeField] private Text WhateverTextThingy;
    //[SerializeField] private string[] StrWhateverTextThingy;
/*
    private void Start()
    {
        StrWhateverTextThingy = new string[4];
        StrWhateverTextThingy[0] = "Молодец!";
        StrWhateverTextThingy[1] = "Правильно!";
        StrWhateverTextThingy[2] = "Супер!";
        StrWhateverTextThingy[3] = "Отлично!";
    }
*/
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

        values = GameObject.Find("values").transform.position;


        if (coord_frame_int == coord_int && coord_frame_string == coord_string && coord_frame_bool == coord_bool && coord_frame_double == coord_double)
        {
            Debug.Log("Равны");
            gb = GameObject.Find("Next");
            gb.GetComponent<Button>().interactable = true;

            //WhateverTextThingy.text = StrWhateverTextThingy[Random.Range(0, StrWhateverTextThingy.Length)];
            WhateverTextThingy.enabled = true;
            timeWhenDisappear = Time.time + timeToAppear;
        }
        //       else if(coord_frame_int != coord_int && coord_frame_string != coord_string && coord_frame_bool != coord_bool && coord_frmae_double != coord_double)
        //       {
        //           coord_int = values;
        //       }

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

/*
 * using System.Collections;
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
    public Vector3 values;

    public GameObject gb;

    //public Text WhateverTextThingy;
    public float timeToAppear = 2f;
    private float timeWhenDisappear;
    [SerializeField] private Text WhateverTextThingy;
    [SerializeField] private string[] StrWhateverTextThingy;

    private void Start()
    {
        StrWhateverTextThingy = new string[4];
        StrWhateverTextThingy[0] = "Молодец!";
        StrWhateverTextThingy[1] = "Правильно!";
        StrWhateverTextThingy[2] = "Супер!";
        StrWhateverTextThingy[3] = "Отлично!";
    }

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

        values = GameObject.Find("values").transform.position;


        if (coord_frame_int == coord_int && coord_frame_string == coord_string && coord_frame_bool == coord_bool && coord_frmae_double == coord_double)
        {
            Debug.Log("Равны");
            gb = GameObject.Find("Next");
            gb.GetComponent<Button>().interactable = true;

            WhateverTextThingy.text = StrWhateverTextThingy[Random.Range(0, StrWhateverTextThingy.Length)];
            WhateverTextThingy.enabled = true;
            timeWhenDisappear = Time.time + timeToAppear;
        }
        //       else if(coord_frame_int != coord_int && coord_frame_string != coord_string && coord_frame_bool != coord_bool && coord_frmae_double != coord_double)
        //       {
        //           coord_int = values;
        //       }

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
*/

