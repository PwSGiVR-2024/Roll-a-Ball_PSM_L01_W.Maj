using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Light : MonoBehaviour
{
    Vector3 offset;
    private Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        LightPosition();
    }

    private void LightPosition()
    {
        transform.position = offset + player.transform.position;
    }
}
