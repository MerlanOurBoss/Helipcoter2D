using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Heli : MonoBehaviour
{
    public float energi = 90f;
    public Text tim;
    public AudioSource audi;
    public float engineSpeed = 1000;
    public float rotationForce = 50;
    public Animator anim;
    private Rigidbody2D rg;

    public static Heli bat;

    private void Awake()
    {
        bat = this;
    }

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        flying();
    }


    public void flying()
    {
        anim.Play("helicopter");
        energi -= 1 * Time.deltaTime;
        if (energi > 0)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rg.AddForce(transform.up * engineSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.back * rotationForce * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.forward * rotationForce * Time.deltaTime);
            }
            tim.text = " " + energi.ToString("0");
        }
    }
}
