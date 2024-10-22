using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class movementController : MonoBehaviour
{
    public float thrust = 5.0f;
    public Rigidbody rb;
    float x = 0;
    float y = 0;
    float z = 0;
    private int score;
    public Text scoreText;
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

        if (Input.GetKey(KeyCode.W))
        { rb.AddForce(Vector3.forward * thrust); }

        if (Input.GetKey(KeyCode.S))
        { rb.AddForce(Vector3.back * thrust); }

        if (Input.GetKey(KeyCode.A))
        { rb.AddForce(Vector3.left * thrust); }

        if (Input.GetKey(KeyCode.D))
        { rb.AddForce(Vector3.right * thrust); }
    }

    public void CollectScore()
    {
        score += 1;
        Debug.Log("zdobyles punkt, masz teraz:" + score);

        if (score >= 12)
        {
            Debug.Log("----------------------------------------");
            Debug.Log("wygrales:)");
            Debug.Log("----------------------------------------");
        }
    }

    public void TextScore()
    {
        score += 1;
        Debug.Log("SCORE: " + score);
    }
}
