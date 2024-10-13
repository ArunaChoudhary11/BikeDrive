using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiamondBuy_UI : MonoBehaviour
{
    [SerializeField] int slot1Cost;
    [SerializeField] int slot2Cost;
    [SerializeField] int slot3Cost;
    [SerializeField] int slot4Cost;
    [SerializeField] int slot5Cost;
    [SerializeField] int slot6Cost;


    [SerializeField] int diamondsEarn;
    [SerializeField] int diamondsEarn2;
    [SerializeField] int diamondsEarn3;
    [SerializeField] int diamondsEarn4;
    [SerializeField] int diamondsEarn5;
    [SerializeField] int diamondsEarn6;

    [SerializeField] TextMeshProUGUI buyText;

    private void Start()
    {
        buyText.gameObject.SetActive(false);
    }

    public void slot1()
    {
        if(Score_Highscore_Currency_Manager.Instance.totalCoins < slot1Cost)
        {
            Show();
            buyText.text = " Not Enough Coins ";
            Invoke("Hide", 2);
            return;
        }
        Score_Highscore_Currency_Manager.Instance.SpendCoin(slot1Cost);
        Show();
        Score_Highscore_Currency_Manager.Instance.diamonds += diamondsEarn;
        Score_Highscore_Currency_Manager.Instance.DiamondSave(diamondsEarn);
        buyText.text = " Purchased Succesfully";
        Invoke("Hide", 2);
        return;
    }

    public void slot2()
    {
        if (Score_Highscore_Currency_Manager.Instance.totalCoins < slot2Cost)
        {
            Show();
            buyText.text = " Not Enough Coins ";
            Invoke("Hide", 2);
            return;
        }
        Score_Highscore_Currency_Manager.Instance.SpendCoin(slot2Cost);
        Show();
        Score_Highscore_Currency_Manager.Instance.diamonds += diamondsEarn2;
        Score_Highscore_Currency_Manager.Instance.DiamondSave(diamondsEarn2);
        buyText.text = " Purchased Succesfully";
        Invoke("Hide", 2);
        return;
    }
    public void slot3()
    {
        if (Score_Highscore_Currency_Manager.Instance.totalCoins < slot3Cost)
        {
            Show();
            buyText.text = " Not Enough Coins ";
            Invoke("Hide", 2);
            return;
        }
        Score_Highscore_Currency_Manager.Instance.SpendCoin(slot3Cost);
        Show();
        Score_Highscore_Currency_Manager.Instance.diamonds += diamondsEarn3;
        Score_Highscore_Currency_Manager.Instance.DiamondSave(diamondsEarn3);
        buyText.text = " Purchased Succesfully";
        Invoke("Hide", 2);
        return;
    }
    public void slot4()
    {
        if (Score_Highscore_Currency_Manager.Instance.totalCoins < slot4Cost)
        {
            Show();
            buyText.text = " Not Enough Coins ";
            Invoke("Hide", 2);
            return;
        }
        Score_Highscore_Currency_Manager.Instance.SpendCoin(slot4Cost);
        Show();
        Score_Highscore_Currency_Manager.Instance.diamonds += diamondsEarn4;
        Score_Highscore_Currency_Manager.Instance.DiamondSave(diamondsEarn4);
        buyText.text = " Purchased Succesfully";
        Invoke("Hide", 2);
        return;
    }
    public void slot5()
    {
        if (Score_Highscore_Currency_Manager.Instance.totalCoins < slot5Cost)
        {
            Show();
            buyText.text = " Not Enough Coins ";
            Invoke("Hide", 2);
            return;
        }
        Score_Highscore_Currency_Manager.Instance.SpendCoin(slot5Cost);
        Show();
        Score_Highscore_Currency_Manager.Instance.diamonds += diamondsEarn5;
        Score_Highscore_Currency_Manager.Instance.DiamondSave(diamondsEarn5);
        buyText.text = " Purchased Succesfully";
        Invoke("Hide", 2);
        return;
    }
    public void slot6()
    {
        if (Score_Highscore_Currency_Manager.Instance.totalCoins < slot6Cost)
        {
            Show();
            buyText.text = " Not Enough Coins ";
            Invoke("Hide", 2);
            return;
        }
        Score_Highscore_Currency_Manager.Instance.SpendCoin(slot6Cost);
        Show();
        Score_Highscore_Currency_Manager.Instance.diamonds += diamondsEarn6;
        Score_Highscore_Currency_Manager.Instance.DiamondSave(diamondsEarn6);
        buyText.text = " Purchased Succesfully";
        Invoke("Hide", 2);
        return;
    }

    private void Show()
    {
        buyText.gameObject.SetActive(true);
        buyText.text = " ";
    }
    private void Hide()
    {
        buyText.gameObject.SetActive(false);
    }

}
