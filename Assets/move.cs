using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class move : MonoBehaviour
{


    Rigidbody kulka;
    public float speed = 20f;
    public float speed_m = -20f;

    void ruch()
        {

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                kulka.AddForce(0, 0, speed);
            }

            else if (Input.GetKey(KeyCode.RightArrow))
            {
                kulka.AddForce(0, 0, speed_m);
            }

            else if (Input.GetKey(KeyCode.UpArrow))
            {
                kulka.AddForce(speed, 0, 0);
            }

            else if (Input.GetKey(KeyCode.DownArrow))
            {
                kulka.AddForce(speed_m, 0, 0);
            }

        }

        void Start()
        {
            kulka = GetComponent<Rigidbody>();
        }

        void FixedUpdate()
        {
            ruch();
        }

    
}
