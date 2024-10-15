using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class movementController : MonoBehaviour
{
    public float thrust = 5.0f;
    public Rigidbody rb;
    float move = 0;
    float x = 0;
    float y = 0;
    float z = 0;
    //public void AddForce(float x, float y, float z, ForceMode mode = ForceMode.Force);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.AddForce(x, y, z);
    }

    void Update()
    {
        float x = 0;
        float z = 0;

        if (Input.GetKey(KeyCode.W))
        { z = z + 1; }

        if (Input.GetKey(KeyCode.S))
        { z = z - 1; }

        if (Input.GetKey(KeyCode.A))
        { x = x + 1; }

        if (Input.GetKey(KeyCode.D))
        { x = x - 1; }
    }
}
