using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class profileUser : MonoBehaviour
{
    public Text highScoreText; 
    public int highScore;
    public ScoreManager scoreManager;
    public Text TotalCoinText;
    public int ToTalCoin;
    //public PlayerMovement PlayerMovement;
    public coinCounter cc;
    void Start()
    {
        totalCoin();
    }

    // Update is called once per frame
    void Update()
    {
        highScore = PlayerPrefs.GetInt("HIgh_Score", 0);
       // highScore = scoreManager.highScore;
        highScoreText.text = "Highscore:" + highScore.ToString();
    }
    void totalCoin()
    {
        ToTalCoin = PlayerPrefs.GetInt("TotalCoin", 0);
        ToTalCoin += cc.coinCount;

        PlayerPrefs.SetInt("TotalCoin", ToTalCoin);
        TotalCoinText.text = PlayerPrefs.GetInt("TotalCoin").ToString();
    }
}
