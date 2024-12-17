using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class TextScore : MonoBehaviour
{
	public Text scoreText;
	public int score;
	public event Action PickUpEvent;

	void Update()
	{
		ScoreText();
		CheckPoint();
        NextLevel();
    }
	public void ScoreText()
	{
		scoreText.text = "SCORE: " + score;
	}
	public void CollectScore()
	{
		score += 1;
        PickUpEvent?.Invoke();
        Debug.Log("zdobyles punkt, masz teraz: " + score);
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
    public void NextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2 & score >= 12) SceneManager.LoadScene(3);
    }
}