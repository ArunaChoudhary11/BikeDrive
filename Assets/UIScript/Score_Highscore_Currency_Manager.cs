using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Highscore_Currency_Manager : MonoBehaviour
{
    public static Score_Highscore_Currency_Manager Instance;

    public int coins;
    public int score;
    public int diamonds;
    
    public int totalCoins;
    public int highscore;


    // Start is called before the first frame update
    void Start()
    {
        if(Instance == null)
        {
         Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        highscore = PlayerPrefs.GetInt("highscore", 0);
        totalCoins = PlayerPrefs.GetInt("TotalCoins", 0);
        diamonds = PlayerPrefs.GetInt("Diamonds", 0);
    }
    private void FixedUpdate()
    {
        
    }

    public void GameStart()
    {
        score = 0;
    }

    public void Restart()
    {

        score = 0;
        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore", highscore);
            PlayerPrefs.Save();
           
        }
    }
    public void TotalCoins(int coins)
    {
       totalCoins += coins;
         
        PlayerPrefs.SetInt("TotalCoins",totalCoins);
        PlayerPrefs.Save();
    }

    public void DiamondSave(int saveIndex)
    {
        PlayerPrefs.SetInt("Diamonds", saveIndex);
        PlayerPrefs.Save();
    }

    public bool CanAffordCoin(int coin)
    {
        return totalCoins >= coin;
    }

    public bool SpendCoin(int coins)
    {
        if (CanAffordCoin(coins))
        {
            totalCoins -= coins;
            PlayerPrefs.SetInt("TotalCoins", totalCoins);
            PlayerPrefs.Save();
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool CanAfford(int Diamonds)
    {
        return diamonds >= Diamonds;
    }

    public bool SpendDiamonds(int Diamonds)
    {
        if (CanAfford(Diamonds))
        {
            diamonds -= Diamonds;
            DiamondSave(Diamonds);
            return true;
        }
        else
        {
            return false;
        }
    }
}
