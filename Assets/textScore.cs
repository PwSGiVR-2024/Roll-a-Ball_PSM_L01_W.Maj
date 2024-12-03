using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class TextScore : MonoBehaviour
{
    
    public Text scoreText;

    void Update()
    {
        ScoreText();
    }

    public void ScoreText()
    {
        scoreText.text = "SCORE: " + .score;
    }
}