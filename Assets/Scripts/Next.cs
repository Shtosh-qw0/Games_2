using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//������, ������� �������� �� ������� �� ����� �����

public class Next : MonoBehaviour
{
    public void Next_Scene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ClicTrigger()
    {
        LevelController.instance.isEndGame();
    }
}
