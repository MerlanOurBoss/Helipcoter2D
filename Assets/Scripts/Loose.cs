using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Loose : MonoBehaviour
{
    [SerializeField] private GameObject _losePanel;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        lose();
    }

    void lose()
    {
        _losePanel.SetActive(true);
        Heli hel = FindObjectOfType<Heli>();
        hel.engineSpeed = 0;
        hel.rotationForce = 0;
        hel.audi.enabled = false;
        hel.anim.enabled = false;
    }
}
