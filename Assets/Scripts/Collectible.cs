using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(10*Time.deltaTime, 0, 0);
    }

    void OnCollisionEnter()
    {
        gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider collision)
    {
        collision.gameObject.GetComponent<TextScore>().CollectScore();
        gameObject.SetActive(false);
    }
}
