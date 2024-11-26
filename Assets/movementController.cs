using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class movementController : MonoBehaviour
{
    public float thrust = 5.0f;
    public float jump = 5.0f;
    public Rigidbody rb;
    private bool lezy = true;
    float x = 0;
    float y = 0;
    float z = 0;
    public int score;
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

        if (Input.GetKey(KeyCode.Space) && lezy)
        { rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
        lezy = false;}

        if (score >= 12)
        {
            Debug.Log("----------------------------------------");
            Debug.Log("wygrales:)");
            Debug.Log("----------------------------------------");
        }
    }

    void OnCollisionEnter(Collision GetContacts)
    {
        if (GetContacts.gameObject)
        {
            lezy = true;
        }
    }

    public void CollectScore()
    {
        score += 1;
        Debug.Log("zdobyles punkt, masz teraz: " + score);
    }

    public void TextScore()
    {
        score += 1;
        Debug.Log("SCORE: " + score);
    }
}
