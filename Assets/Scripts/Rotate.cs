using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 20 * Time.deltaTime, 0);
    }
}
