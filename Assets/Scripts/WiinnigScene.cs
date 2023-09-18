using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WiinnigScene : MonoBehaviour
{
    [SerializeField] private GameObject _winPanel;

    void winnnigPane()
    {
        Heli hel = FindObjectOfType<Heli>();
        _winPanel.SetActive(true);
        hel.engineSpeed = 0;
        hel.rotationForce = 0;
        hel.audi.enabled = false;
        hel.anim.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        winnnigPane();
    }
}
