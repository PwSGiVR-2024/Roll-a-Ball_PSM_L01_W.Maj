using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private GameObject[] Points;
    private int MaxScore;

    void Update()
    {
        Points = GameObject.FindGameObjectsWithTag("Point");
        MaxScore = Points.Length;
    }
}
