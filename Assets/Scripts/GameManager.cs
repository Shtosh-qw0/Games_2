using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text text;
    public string[] texts;
    public int count = 0;
    int size = 0;
    public GameObject NextButtonThingy;
    //public GameObject VideoInfo;

    void Start()
    {
        count = 0;
        text.text = texts[count];
        NextButtonThingy.SetActive(false);
        //VideoInfo.SetActive(false);
        count = 1;
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

    /*public void ExplanationTask()
    {
        if(count == 3)
        {
            VideoInfo.SetActive(true);
        }
    }*/

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
