using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    private void Awake()
    {
       // AdmobAdsScript.instance.LoadInterstitialAd();
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    

    }

    public void GoToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    public void Tutorial()
    {
   
            if (SceneManager.GetActiveScene().buildIndex != 2)
            {
                SceneManager.LoadScene("AdMob");
            }
            else
            {

            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
       
    }

    public void GoToGameplay()
    {
         
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        Score_Highscore_Currency_Manager.Instance.Restart();
       

    }
}
