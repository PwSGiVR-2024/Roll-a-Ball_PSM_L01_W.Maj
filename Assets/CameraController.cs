using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public movementController playerController;
    // public Camera cam;
    Vector3 offset;
    private float alpha = 0;
    private float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
       // cam = GetComponent<Camera>();
        //player.transform.position = transform.position;
        //playerController.transform.position = transform.position;
        //transform.rotation = player.transform.rotation;
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = offset + player.transform.position;
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.rotation = Quaternion.Euler(40, y-180, 0);
        //}

        float angle = speed * Time.deltaTime;
        alpha = alpha + angle;
        angle = 0;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(40, -alpha, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(40, alpha, 0);
        }
    }
}