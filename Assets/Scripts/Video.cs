using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Video : MonoBehaviour
{
    public GameObject VideoInfo;
    public int count = 0;

    void Start()
    {
        VideoInfo.SetActive(false);
    }

    public void ButtonClick()
    {
        count++;
    }

    public void ExplanationTask()
    {
        if (count == 3)
        {
            VideoInfo.SetActive(true);
        }
    }
}
