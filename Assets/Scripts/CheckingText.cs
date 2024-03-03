using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CheckingText : MonoBehaviour
{
//    public GameObject MainPanel;
    public TMP_InputField InWord;
    public string Word;
    public GameObject gb;
    public Text WhateverTextThingy;
    int count = 0;
/*
    void Start()
    {
        count = 0;
    }
*/
    public void CheckingInputWord()
    {
        if (InWord.text == Word)
        {
            Debug.Log("Правильно");
            gb = GameObject.Find("Next");
            gb.GetComponent<Button>().interactable = true;
            WhateverTextThingy.enabled = true;
            count = 1;
        }
        
        else
        {
            Debug.Log("Не правильно");
        }
    }

    void Update()
    {
        if (WhateverTextThingy.enabled && count == 0)
        {
            WhateverTextThingy.enabled = false;
        }
    }
}
