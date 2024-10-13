using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public AdmobAdsScript admobAdsScript;

    [SerializeField] TextMeshProUGUI totalCoins;
    [SerializeField] TextMeshProUGUI highscore;
    [SerializeField] TextMeshProUGUI score;

    public GameObject prefabAdMob, parentAdMob, gameOverPanel;
    public bool isAdShown = false;
    public GameObject tempGO;
    
    // Start is called before the first frame update
    void Start()
    { 

    }
    public void Restart()
    {
        PlayerPrefs.Save();
        int rnd = Random.Range(1, 20);
        if (rnd % 2 == 0)
        {
            isAdShown = true;
            print("adsSceneLoad");
            if (admobAdsScript != null)
            {
                admobAdsScript.ShowInterstitialAd();
            }
            else
            {
                Debug.LogError("AdmobAdsScript is not assigned or found!");
            }
            SceneManager.LoadScene("AdMob" );


            // tempGO= Instantiate(prefabAdMob, parentAdMob.transform);
        }
        else
        {
            SceneManager.LoadScene("Gameplay");
        }
        gameOverPanel.SetActive(false);
        if (isAdShown == false)
        {

            Score_Highscore_Currency_Manager.Instance.Restart();

            SceneManager.LoadScene("GamePlay");

        }
    }

        int hig;

        private void FixedUpdate()
        {
            if (totalCoins != null)
            {
                totalCoins.text = "Coins:- " + PlayerPrefs.GetInt("TotalCoins", 0).ToString();

                highscore.text = "HighScore:- " + hig.ToString();


                if (Score_Highscore_Currency_Manager.Instance.score == 0)
                {
                    score.text = "Score:- 0";

                }
                else
                {
                    score.text = "Score:- " + Score_Highscore_Currency_Manager.Instance.score.ToString();


                }
            }

        }

        // Update is called once per frame

    }

