using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batery : MonoBehaviour
{
    [SerializeField] private Heli _hel;
    [SerializeField] private GameObject _canvasPanel;

    public void Power()
    {
        _hel.energi += 10;
        Destroy(gameObject);
        Destroy(_canvasPanel);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Power();
    }

}
