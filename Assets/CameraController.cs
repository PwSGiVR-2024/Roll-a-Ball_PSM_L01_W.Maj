using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public movementController playerController;
    // public Camera cam;
    Vector3 offset;
    
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
    }
}
