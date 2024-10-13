using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using ScreenCaptureShare.ScreenCapture.Managers;
using UnityEngine.SocialPlatforms.Impl;

public class GmaController : MonoBehaviour
{
    public AdmobAdsScript admobAdsScript;

    public static GmaController instance;
    public GameObject gamePausePanel;
    public GameObject gamePauseButton;
    [SerializeField] Transform settingUI;
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI highscore;
    [SerializeField] GameObject countDown;


    public GameObject prefabAdMob,parentAdMob,gameOverPanel;
    public bool isAdShown = false;
    public GameObject tempGO;

    public void TutorialRestart()
    {
      
        SceneManager.LoadScene(2);
    }
    // Start is called before the first frame update
    void Start()
    {
        gamePausePanel.SetActive(false);
        gamePauseButton.SetActive(true);
        if(countDown!=null)
        {
            countDown.gameObject.SetActive(true);
            Destroy(countDown, 7f);
        }
       
        instance = this;
         // Assign admobAdsScript dynamically if not assigned in Inspector
      

        

    }

    private void FixedUpdate()
    {
        if (score != null)
        {
            score.text = Score_Highscore_Currency_Manager.Instance.score.ToString();
            highscore.text = Score_Highscore_Currency_Manager.Instance.highscore.ToString();
        }
     
        
    }
    public void Rewar()
    {
        PlayerPrefs.Save();

        admobAdsScript.ShowRewardedAd();
        {
            isAdShown = true;
            print("adsSceneLoad");
            if (admobAdsScript != null)
            {
                admobAdsScript.ShowRewardedAd();

            }
            
            SceneManager.LoadScene("AdMob");


            // tempGO= Instantiate(prefabAdMob, parentAdMob.transform);
        }
       
      
        gameOverPanel.SetActive(false);
        if (isAdShown == false)
        {

            Score_Highscore_Currency_Manager.Instance.Restart();

            SceneManager.LoadScene("GamePlay");

        }
    }
    public void Restart()
    {
        PlayerPrefs.Save();
        int rnd = Random.Range(1, 20);
        if (rnd % 2 == 0)
        {
           // isAdShown = true;
          //  print("adsSceneLoad");
          // if (admobAdsScript != null)
           // {
                //admobAdsScript.ShowInterstitialAd();
               
           // }
            //else
           // {
          //      Debug.LogError("AdmobAdsScript is not assigned or found!");
          //  }
            SceneManager.LoadScene("AdMob");


            // tempGO= Instantiate(prefabAdMob, parentAdMob.transform);
        }
        else
        {
            SceneManager.LoadScene("Gameplay");
        }
        gameOverPanel.SetActive(false);
        if (isAdShown==false)
        {

            Score_Highscore_Currency_Manager.Instance.Restart();

            SceneManager.LoadScene("GamePlay");
            
        }
        /*else
        {
            Invoke("HideAddAndOpenScene", 0.5f);
        }*/
       
       
       
    }
   
    public void HideAddAndOpenScene()
    {
        isAdShown = false;
       
        if (tempGO != null)
            tempGO = null;
        Score_Highscore_Currency_Manager.Instance.Restart();
        SceneManager.LoadScene("GamePlay");
        
    }
    public void Pausegame()
    {
        Time.timeScale = 0;
        gamePausePanel.SetActive(true);
        gamePauseButton.SetActive(false);
        
    }
    public void Game()
    {
        Time.timeScale = 1;
        gamePausePanel.SetActive(false );
        gamePauseButton.SetActive(true);

    }
    public void MainMenu()
    {
        SceneManager.LoadScene("mainmenu");
        Score_Highscore_Currency_Manager.Instance.Restart();
    }
    public void OpenSetting()
    {
        settingUI.gameObject.SetActive(true);
    }
}
