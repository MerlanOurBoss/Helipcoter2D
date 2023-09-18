using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 1f;
    }
    public void loadLevel(int i)
    {
        SceneManager.LoadScene(i);
    }

    public void gameExit()
    {
        Application.Quit();
    }
}
