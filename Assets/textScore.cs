using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class textScore : MonoBehaviour
{
    public Text scoreText;
    public void ScoreText()
    {
        scoreText.text = "SCORE: " + GetComponent<movementController>().score;
    }
}
