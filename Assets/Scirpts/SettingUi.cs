using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SettingUi : MonoBehaviour
{
    public static SettingUi instance;
    [SerializeField] Button soundMute;
    [SerializeField] Transform soundOnIcon;
    [SerializeField] Transform soundOffIcon;
    [SerializeField] Button musicMute;
    [SerializeField] Transform musicOnIcon;
    [SerializeField] Transform musicOffIcon;
    [SerializeField] Button moreGames;
    [SerializeField] Button companyInfo;
    [SerializeField] Button okButton;
    [SerializeField] Button ComapnyInfo;
    [SerializeField] Button MoreGames;
    [SerializeField] Transform shopUiClose;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        gameObject.SetActive(false);
        soundOnIcon.gameObject.SetActive(true);
        musicOnIcon.gameObject.SetActive(true);
        MusicManager.Instance.musicSource.volume = 0.5f;
        SoundManager.Instance._effectSource.volume = 0.5f;

      

        musicMute.onClick.AddListener(() =>
        {

            MusicMute();
        });

        soundMute.onClick.AddListener(() =>
        {
            EffectMute();

        });


        moreGames.onClick.AddListener(() =>
        {

        });

        companyInfo.onClick.AddListener(() =>
        {

        });
        okButton.onClick.AddListener(() =>
        {
            Back();
        });

        Hide();
    }

    private void Back()
    {
        gameObject.SetActive(false);
    }

    private void EffectMute()
    {
        if (!soundOnIcon.gameObject.activeSelf == true)
        {
            SoundManager.Instance._effectSource.volume = 1;
            soundOnIcon.gameObject.SetActive(true);
            soundOffIcon.gameObject.SetActive(false);
        }
        else  
        {
            SoundManager.Instance._effectSource.volume = 0;
            soundOffIcon.gameObject.SetActive(true);
            soundOnIcon.gameObject.SetActive(false);

        }
    }
    public void MusicMute()
    {

        if (!musicOnIcon.gameObject.activeSelf == true)
        {
            MusicManager.Instance.musicSource.volume = 0.5f;
            musicOnIcon.gameObject.SetActive(true);
            musicOffIcon.gameObject.SetActive(false);
            MusicManager.Instance.musicSource.Play();
        }
        else
        {
            MusicManager.Instance.musicSource.volume = 0;
            musicOffIcon.gameObject.SetActive(true);
            musicOnIcon.gameObject.SetActive(false);
            MusicManager.Instance.musicSource.Stop();
        }
    }

    private void Instance_OnSettingBtnClick(object sender, System.EventArgs e)
    {
        Show();
       
        // TapToPlayTutorial.Instance.Hide();   
         Debug.Log("show");

    }


    // Update is called once per frame
    void Update()
    {

    }



    private void Show()
    {
        if (!gameObject.activeSelf == true)
        {
            gameObject.SetActive(true);

        }
        else
        {
            Hide();

        }

    }
    private void Hide()
    {
        gameObject.SetActive(false);
       

    }
    public void company()
    {
        Application.OpenURL("https://codex2d.com");
    }
    public void Games()
    {
        Application.OpenURL("https://play.google.com/store/apps/dev?id=7946245812126462670&pli=1 ");
    }
}
