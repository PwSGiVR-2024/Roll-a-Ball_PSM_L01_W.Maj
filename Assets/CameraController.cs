using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    private Transform player;
    Vector3 offset;
    private float alpha = 0;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        CameraPosiotion();
        Rotate();
    }

    public void Rotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(40, -alpha, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(40, alpha, 0);
        }
    }

    private void CameraPosiotion()
    {
        transform.position = offset + player.transform.position;
    }
}

//proba zmiany k¹ta kamery // do update'u

    //private float speed = 10;

//float angle = speed * Time.deltaTime;
//alpha = alpha + angle;
//angle = 0;
//
//TO SA TE TRZY LINIJKI
//float tiltAroundY = Input.GetAxis("Horizontal") * tiltAngle;
//Quaternion target = Quaternion.Euler(20, tiltAroundY, 0);
//transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);