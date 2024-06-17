using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonLevels : MonoBehaviour
{
    //Управление уровнями

    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    public GameObject level6;
    public GameObject level7;
    public GameObject level8;
    public GameObject level9;
    public GameObject level10;
    public GameObject level11;
    public GameObject level12;
    public GameObject level13;
    public GameObject level14;
    public GameObject level15;
    public GameObject level16;
    public GameObject level17;
    public GameObject level18;
    public GameObject level19;
    public GameObject level20;
    int levelComplete;

    void Start()
    {
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        level2.SetActive(false);
        level3.SetActive(false);
        level4.SetActive(false);
        level5.SetActive(false);
        level6.SetActive(false);
        level7.SetActive(false);
        level8.SetActive(false);
        level9.SetActive(false);
        level10.SetActive(false);
        level11.SetActive(false);
        level12.SetActive(false);
        level13.SetActive(false);
        level14.SetActive(false);
        level15.SetActive(false);
        level16.SetActive(false);
        level17.SetActive(false);
        level18.SetActive(false);
        level19.SetActive(false);
        level20.SetActive(false);

        switch (levelComplete)
        {
            case 3:
                level2.SetActive(true);
                break;

            case 4:
                level2.SetActive(true);
                level3.SetActive(true);
                break;

            case 5:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                break;

            case 7:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                level5.SetActive(true);
                break;

            case 8:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                level5.SetActive(true);
                level6.SetActive(true);
                break;

            case 9:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                level5.SetActive(true);
                level6.SetActive(true);
                level7.SetActive(true);
                break;

            case 11:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                level5.SetActive(true);
                level6.SetActive(true);
                level7.SetActive(true);
                level8.SetActive(true);
                break;

            case 12:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                level5.SetActive(true);
                level6.SetActive(true);
                level7.SetActive(true);
                level8.SetActive(true);
                level9.SetActive(true);
                break;

            case 13:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                level5.SetActive(true);
                level6.SetActive(true);
                level7.SetActive(true);
                level8.SetActive(true);
                level9.SetActive(true);
                level10.SetActive(true);
                break;

            case 14:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                level5.SetActive(true);
                level6.SetActive(true);
                level7.SetActive(true);
                level8.SetActive(true);
                level9.SetActive(true);
                level10.SetActive(true);
                level11.SetActive(true);
                break;

            case 16:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                level5.SetActive(true);
                level6.SetActive(true);
                level7.SetActive(true);
                level8.SetActive(true);
                level9.SetActive(true);
                level10.SetActive(true);
                level11.SetActive(true);
                level12.SetActive(true);
                break;

            case 18:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                level5.SetActive(true);
                level6.SetActive(true);
                level7.SetActive(true);
                level8.SetActive(true);
                level9.SetActive(true);
                level10.SetActive(true);
                level11.SetActive(true);
                level12.SetActive(true);
                level13.SetActive(true);
                break;

            case 20:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                level5.SetActive(true);
                level6.SetActive(true);
                level7.SetActive(true);
                level8.SetActive(true);
                level9.SetActive(true);
                level10.SetActive(true);
                level11.SetActive(true);
                level12.SetActive(true);
                level13.SetActive(true);
                level14.SetActive(true);
                break;

            case 21:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                level5.SetActive(true);
                level6.SetActive(true);
                level7.SetActive(true);
                level8.SetActive(true);
                level9.SetActive(true);
                level10.SetActive(true);
                level11.SetActive(true);
                level12.SetActive(true);
                level13.SetActive(true);
                level14.SetActive(true);
                level15.SetActive(true);
                break;

            case 22:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                level5.SetActive(true);
                level6.SetActive(true);
                level7.SetActive(true);
                level8.SetActive(true);
                level9.SetActive(true);
                level10.SetActive(true);
                level11.SetActive(true);
                level12.SetActive(true);
                level13.SetActive(true);
                level14.SetActive(true);
                level15.SetActive(true);
                level16.SetActive(true);
                break;

            case 23:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                level5.SetActive(true);
                level6.SetActive(true);
                level7.SetActive(true);
                level8.SetActive(true);
                level9.SetActive(true);
                level10.SetActive(true);
                level11.SetActive(true);
                level12.SetActive(true);
                level13.SetActive(true);
                level14.SetActive(true);
                level15.SetActive(true);
                level16.SetActive(true);
                level17.SetActive(true);
                break;

            case 25:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                level5.SetActive(true);
                level6.SetActive(true);
                level7.SetActive(true);
                level8.SetActive(true);
                level9.SetActive(true);
                level10.SetActive(true);
                level11.SetActive(true);
                level12.SetActive(true);
                level13.SetActive(true);
                level14.SetActive(true);
                level15.SetActive(true);
                level16.SetActive(true);
                level17.SetActive(true);
                level18.SetActive(true);
                break;

            case 26:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                level5.SetActive(true);
                level6.SetActive(true);
                level7.SetActive(true);
                level8.SetActive(true);
                level9.SetActive(true);
                level10.SetActive(true);
                level11.SetActive(true);
                level12.SetActive(true);
                level13.SetActive(true);
                level14.SetActive(true);
                level15.SetActive(true);
                level16.SetActive(true);
                level17.SetActive(true);
                level18.SetActive(true);
                level19.SetActive(true);
                break;

            case 28:
                level2.SetActive(true);
                level3.SetActive(true);
                level4.SetActive(true);
                level5.SetActive(true);
                level6.SetActive(true);
                level7.SetActive(true);
                level8.SetActive(true);
                level9.SetActive(true);
                level10.SetActive(true);
                level11.SetActive(true);
                level12.SetActive(true);
                level13.SetActive(true);
                level14.SetActive(true);
                level15.SetActive(true);
                level16.SetActive(true);
                level17.SetActive(true);
                level18.SetActive(true);
                level19.SetActive(true);
                level20.SetActive(true);
                break;
        }
    }

    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Reset()
    {
        level2.SetActive(false);
        level3.SetActive(false);
        level4.SetActive(false);
        level5.SetActive(false);
        level6.SetActive(false);
        level7.SetActive(false);
        level8.SetActive(false);
        level9.SetActive(false);
        level10.SetActive(false);
        level11.SetActive(false);
        level12.SetActive(false);
        level13.SetActive(false);
        level14.SetActive(false);
        level15.SetActive(false);
        level16.SetActive(false);
        level17.SetActive(false);
        level18.SetActive(false);
        level19.SetActive(false);
        level20.SetActive(false);
        PlayerPrefs.DeleteAll();
    }
}
