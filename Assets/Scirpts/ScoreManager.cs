using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    INGameUI gameUI;
   public int score = 0;
  public int highScore = 0;
    // public static int lastScore = 0; 

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    // public Text lastScoreText;

    void Start()
    {
        StartCoroutine(Score());
        
        highScore = PlayerPrefs.GetInt("high_Score", 0);
        
        highScoreText.text = "HighScore: " + highScore.ToString();
        
    }

    void Update()
    {
        scoreText.text = score.ToString();
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("high_Score", highScore);
            Debug.Log("highScore: " + highScore);
            highScoreText.text = "HighScore: " + highScore.ToString();
        }
    }

    IEnumerator Score()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            score += 1;
            
        }
    }

   

}
