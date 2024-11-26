using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    //public movementController playerController;
    //public new GameObject camera;
    //public Camera cam;
    Vector3 offset;
    //private float alpha = 0;
    //private float speed = 10;

            //do odkomentowania
    //float tiltAngle = 10.0f;
    //float smooth = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        //cam = GetComponent<Camera>();
        //player.transform.position = transform.position;
        //playerController.transform.position = transform.position;
        //transform.rotation = player.transform.rotation;
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = offset + player.transform.position;
        Rotate();
    }

    public void Rotate()
    {
        //float angle = speed * Time.deltaTime;
        //alpha = alpha + angle;
        //angle = 0;
        //
        //TO SA TE TRZY LINIJKI
        //float tiltAroundY = Input.GetAxis("Horizontal") * tiltAngle;
        //Quaternion target = Quaternion.Euler(20, tiltAroundY, 0);
        //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.rotation = (40, -alpha, 0);
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Rotate(40, alpha, 0);
        //}
    }
}