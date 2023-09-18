using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class Pais : MonoBehaviour
{
    public GameObject pauseInGame;
    private bool inGame = true;

    void Update()
    {
        PauseIn();
    }

    public void PauseIn()
    {
        Heli hel = FindObjectOfType<Heli>();


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (inGame)
            {
                pauseInGame.SetActive(true);
                inGame = false;
                Heli.bat.enabled = false;
                hel.anim.enabled = false;
                hel.audi.enabled = false;
                Time.timeScale = 0f;
            }
            else
            {
                pauseInGame.SetActive(false);
                inGame = true;
                Heli.bat.enabled = true;
                hel.anim.enabled = true;
                hel.audi.enabled = true;
                Time.timeScale = 1f;

            }
        }
    }
}

