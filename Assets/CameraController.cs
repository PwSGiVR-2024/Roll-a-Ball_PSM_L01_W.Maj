using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public movementController playerController;
    
    // Start is called before the first frame update
    void Start()
    {
        player.transform.position = transform.position;
        playerController.transform.position = transform.position;
        transform.rotation = player.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
