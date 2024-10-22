using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(10*Time.deltaTime, 0, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        collision.gameObject.GetComponent<movementController>().CollectScore();
        gameObject.SetActive(false);
    }
}
