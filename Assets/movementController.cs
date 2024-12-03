using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using System;

public class MovementController : MonoBehaviour
{
    public float thrust = 5.0f;
    public float jump = 5.0f;
    public Rigidbody rb;
    private bool lezy = true;
    readonly float x = 0;
    readonly float y = 0;
    readonly float z = 0;
    public int score;
    //public Text scoreText;
    public event Action PickUpEvent;

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
        GetInput();
        CheckPoint();
    }

    void OnCollisionEnter(Collision GetContacts)
    {
        if (GetContacts.gameObject)
        {
            lezy = true;
        }
    }
    private void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        { rb.AddForce(Vector3.forward * thrust); }

        if (Input.GetKey(KeyCode.S))
        { rb.AddForce(Vector3.back * thrust); }

        if (Input.GetKey(KeyCode.A))
        { rb.AddForce(Vector3.left * thrust); }

        if (Input.GetKey(KeyCode.D))
        { rb.AddForce(Vector3.right * thrust); }

        if (Input.GetKey(KeyCode.Space) && lezy)
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            lezy = false;
        }
    }
    private void CheckPoint()
    {
        if (score >= 12)
        {
            Debug.Log("----------------------------------------");
            Debug.Log("wygrales:)");
            Debug.Log("----------------------------------------");
        }
    }
    public void CollectScore()
    {
        score += 1;
        PickUpEvent?.Invoke();
        Debug.Log("zdobyles punkt, masz teraz: " + score);
    }
}
