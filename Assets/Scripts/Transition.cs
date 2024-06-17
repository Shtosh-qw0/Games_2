using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public Text text;
    public string[] texts;
    public int count = 0;
    public int size = 0;
    public GameObject NextButtonThingy;

    void Start()
    {
        count = 0;
        text.text = texts[count];
        NextButtonThingy.SetActive(false);
        count = 1;
        if (count == size)
        {
            NextButtonThingy.SetActive(true);
        }
        //text.text = texts[count];
    }

    public void ButClick()
    {

        text.text = texts[count];

        Debug.Log(texts[count]);

        Debug.Log(texts.Length);
        size = texts.Length;

        count++;

    }


    public void Checking—licks()
    {
        if (count == size)
        {
            NextButtonThingy.SetActive(true);
        }
    }

    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

