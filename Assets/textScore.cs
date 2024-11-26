using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class textScore : MonoBehaviour
{
    public Text scoreText;

    void Update()
    {
        ScoreText();
    }
    public void ScoreText()
    {
        scoreText.text = "SCORE: " + GetComponent<movementController>().score;
        print(scoreText.text);
    }
}
