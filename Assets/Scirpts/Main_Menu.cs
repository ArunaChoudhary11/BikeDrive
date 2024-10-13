using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;


public class Main_Menu : MonoBehaviour
{
  
    public static Main_Menu Instance;
    [SerializeField] Transform settingUI;
  
    [SerializeField] TextMeshProUGUI userName;
    [SerializeField] TextMeshProUGUI coins;
    [SerializeField] TextMeshProUGUI hightScore;
    [SerializeField] TextMeshProUGUI diamonds;

    [SerializeField] AudioClip BtnClip;
  

    // [SerializeField] Transform tutorialUI;


  
    public void GoToGameplay() //onButtonClickEvent
    {
        if (!PlayerPrefs.HasKey("TutorialCompleted"))
        {
            SceneManager.LoadScene(2);
            SoundManager.Instance.PlaySound(BtnClip); //audioClick
        }
        else
        {

        SoundManager.Instance.PlaySound(BtnClip); //audioClick
            SceneManager.LoadScene(1);
        }
       // UnityEngine.SceneManagement.SceneManager.LoadScene(1);


    }

  
    // Start is called before the first frame update
    void Start()
    {

        hig = PlayerPrefs.GetInt("highscore", 0);
        Time.timeScale = 1f;
       

      
        


        if (settingUI.gameObject == null)
        {
            return;
        }


    }

    int hig;
    private void FixedUpdate()
    {
        hightScore.text = "Highscore:- " + hig;

        userName.text = PlayerPrefs.GetString("Username");
        coins.text = Score_Highscore_Currency_Manager.Instance.totalCoins.ToString();
        diamonds.text = Score_Highscore_Currency_Manager.Instance.diamonds.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Tutorial()
    {
        GameManager.instance.Tutorial();
    }
    public void Play()
    {
       
        GameManager.instance.GoToGameplay();
    }
    [SerializeField] Transform shop;
    [SerializeField] Transform shopOptionMenu;
    [SerializeField] Transform diamondsBuyPanel;
    [SerializeField] Transform ad_FreePanel;
    public void OpenShop()
    {
        shop.gameObject.SetActive(true);
       
        shopOptionMenu.gameObject.SetActive(true);
        settingUI.gameObject.SetActive(false);
    }

    public void OpenSetting()
    {
        settingUI.gameObject.SetActive(true);
        shop.gameObject.SetActive(false);
        diamondsBuyPanel.gameObject.SetActive(false);
        ad_FreePanel.gameObject.SetActive(false);
        shopOptionMenu.gameObject.SetActive(false);
    }
    public void clsapp()
    {
        Application.Quit();
    }
}
