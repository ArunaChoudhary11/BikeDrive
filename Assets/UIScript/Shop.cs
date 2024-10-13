using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI buyText;

    [Header("BuySystem")]
    [SerializeField] Button buy1Button;
    [SerializeField] Transform buy1image;
    [SerializeField] Transform Sold1image;

    [SerializeField] Button buy2Button;
    [SerializeField] Transform buy2image;
    [SerializeField] Transform Sold2image;

    [SerializeField] Button buy3Button;
    [SerializeField] Transform buy3image;
    [SerializeField] Transform Sold3image;

    [SerializeField] Button buy4Button;
    [SerializeField] Transform buy4image;
    [SerializeField] Transform Sold4image;

    [SerializeField] Button buy5Button;
    [SerializeField] Transform buy5image;
    [SerializeField] Transform Sold5image;

    [SerializeField] Button buy6Button;
    [SerializeField] Transform buy6image;
    [SerializeField] Transform Sold6image;

    [SerializeField] Button buy7Button;
    [SerializeField] Transform buy7image;
    [SerializeField] Transform Sold7image;

    [SerializeField] Button buy8Button;
    [SerializeField] Transform buy8image;
    [SerializeField] Transform Sold8image;

    [SerializeField] Button buy9Button;
    [SerializeField] Transform buy9image;
    [SerializeField] Transform Sold9image;




    [SerializeField] Sprite sprite1;
    [SerializeField] Sprite sprite2;
    [SerializeField] Sprite sprite3;
    [SerializeField] Sprite sprite4;
    [SerializeField] Sprite sprite5;
    [SerializeField] Sprite sprite6;
    [SerializeField] Sprite sprite7;
    [SerializeField] Sprite sprite8;
    [SerializeField] Sprite sprite9;
    [SerializeField] Sprite sprite10;

    public ShipScritableObject selectedSpriteAsset;

    [Header("BuyCoin")]
    [SerializeField] int buyBtn1Cost;
    [SerializeField] int buyBtn2Cost;
    [SerializeField] int buyBtn3Cost;
    [SerializeField] int buyBtn4Cost;
    [SerializeField] int buyBtn5Cost;
    [SerializeField] int buyBtn6Cost;
    [SerializeField] int buyBtn7Cost;
    [SerializeField] int buyBtn8Cost;
    [SerializeField] int buyBtn9Cost;

    [Header("ShipContainerImages")]
    [SerializeField] Image containerShipImage1;
    [SerializeField] Image containerShipImage2;
    [SerializeField] Image containerShipImage3;
    [SerializeField] Image containerShipImage4;
    [SerializeField] Image containerShipImage5;
    [SerializeField] Image containerShipImage6;
    [SerializeField] Image containerShipImage7;
    [SerializeField] Image containerShipImage8;
    [SerializeField] Image containerShipImage9;



    void Start()
    {
        buyText.gameObject.SetActive(false);
        buy1Button.onClick.AddListener(() => {

            PlayerPrefs.GetInt("buy1Purchased", 1);

            if (PlayerPrefs.GetInt("buy1Purchased", 0) == 1) //ya nikal dena agar bar bar buy krna hai toh playerpref sab me se
            {
                Show();
                buyText.text = "Already Purchased & Equiped";
                Sold1image.gameObject.SetActive(true);
                buy1image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                SelectSprite(sprite1);
                return;
            }
            if (Score_Highscore_Currency_Manager.Instance.diamonds < buyBtn1Cost)
            {
                Show();
                buyText.text = "Not Enough Diamonds ";
                buy1image.gameObject.SetActive(true);
                Sold1image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                return;
            }
            Score_Highscore_Currency_Manager.Instance.SpendDiamonds(buyBtn1Cost);
            Show();
            buyText.text = " Succesfully Purchased ";
            PlayerPrefs.SetInt("buy1Purchased", 1);
            PlayerPrefs.Save();
            SelectSprite(sprite1);
            Invoke("Hide", 2);
            return;
        });

        buy2Button.onClick.AddListener(() => {

            if (PlayerPrefs.GetInt("buy2Purchased", 0) == 1) //ya nikal dena agar bar bar buy krna hai toh playerpref sab me se
            {
                Show();
                buyText.text = "Already Purchased & Equiped";
                Sold2image.gameObject.SetActive(true);
                buy2image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                SelectSprite(sprite2);
                return;
            }
            if (Score_Highscore_Currency_Manager.Instance.diamonds < buyBtn2Cost)
            {
                Show();
                buyText.text = "Not Enough Diamonds ";
                buy2image.gameObject.SetActive(true);
                Sold2image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                return;
            }
            Score_Highscore_Currency_Manager.Instance.SpendDiamonds(buyBtn2Cost);
            Show();
            buyText.text = " Succesfully Purchased ";
         
            PlayerPrefs.SetInt("buy2Purchased", 1);
            PlayerPrefs.Save();
            Sold2image.gameObject.SetActive(true);
            buy2image.gameObject.SetActive(false);
            SelectSprite(sprite2);
            Invoke("Hide", 2);
            return;
        });

        buy3Button.onClick.AddListener(() => {

            if (PlayerPrefs.GetInt("buy3Purchased", 0) == 1) //ya nikal dena agar bar bar buy krna hai toh playerpref sab me se
            {
                Show();
                buyText.text = "Already Purchased & Equiped";
                Sold3image.gameObject.SetActive(true);
                buy3image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                SelectSprite(sprite3);
                return;
            }
            if (Score_Highscore_Currency_Manager.Instance.diamonds < buyBtn3Cost)
            {
                Show();
                buyText.text = "Not Enough Diamonds ";
                buy3image.gameObject.SetActive(true);
                Sold3image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                return;
            }
            Score_Highscore_Currency_Manager.Instance.SpendDiamonds(buyBtn3Cost);
            Show();
            buyText.text = " Succesfully Purchased ";
            Sold3image.gameObject.SetActive(true);
            buy3image.gameObject.SetActive(false);
            PlayerPrefs.SetInt("buy3Purchased", 1);
            PlayerPrefs.Save();
            SelectSprite(sprite3);
            Invoke("Hide", 2);
            return;
        });

        buy4Button.onClick.AddListener(() => {

            if (PlayerPrefs.GetInt("buy4Purchased", 0) == 1) //ya nikal dena agar bar bar buy krna hai toh playerpref sab me se
            {
                Show();
                buyText.text = "Already Purchased & Equiped";
                Sold4image.gameObject.SetActive(true);
                buy4image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                SelectSprite(sprite4);
                return;
            }
            if (Score_Highscore_Currency_Manager.Instance.diamonds < buyBtn4Cost)
            {
                Show();
                buyText.text = "Not Enough Diamonds ";
                Sold4image.gameObject.SetActive(true);
                buy4image.gameObject.SetActive(false);
                buy4image.gameObject.SetActive(true);
                Sold4image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                return;
            }
            Score_Highscore_Currency_Manager.Instance.SpendDiamonds(buyBtn4Cost);
            Show();
            buyText.text = " Succesfully Purchased ";
            PlayerPrefs.SetInt("buy4Purchased", 1);
            PlayerPrefs.Save();
            SelectSprite(sprite4);
            Invoke("Hide", 2);
            return;
        });

        buy5Button.onClick.AddListener(() => {

            if (PlayerPrefs.GetInt("buy5Purchased", 0) == 1) //ya nikal dena agar bar bar buy krna hai toh playerpref sab me se
            {
                Show();
                buyText.text = "Already Purchased & Equiped";
                Sold5image.gameObject.SetActive(true);
                buy5image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                SelectSprite(sprite5);
                return;
            }
            if (Score_Highscore_Currency_Manager.Instance.diamonds < buyBtn5Cost)
            {
                Show();
                buyText.text = "Not Enough Diamonds ";
                buy5image.gameObject.SetActive(true);
                Sold5image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                return;
            }
            Score_Highscore_Currency_Manager.Instance.SpendDiamonds(buyBtn5Cost);
            Show();
            buyText.text = " Succesfully Purchased ";
            Sold5image.gameObject.SetActive(true);
            buy5image.gameObject.SetActive(false);
            PlayerPrefs.SetInt("buy5Purchased", 1);
            PlayerPrefs.Save();
            SelectSprite(sprite5);
            Invoke("Hide", 2);
            return;
        });

        buy6Button.onClick.AddListener(() => {

            if (PlayerPrefs.GetInt("buy6Purchased", 0) == 1) //ya nikal dena agar bar bar buy krna hai toh playerpref sab me se
            {
                Show();
                buyText.text = "Already Purchased & Equiped";
                Sold6image.gameObject.SetActive(true);
                buy6image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                SelectSprite(sprite6);
                return;
            }
            if (Score_Highscore_Currency_Manager.Instance.diamonds < buyBtn6Cost)
            {
                Show();
                buyText.text = "Not Enough Diamonds ";
                buy6image.gameObject.SetActive(true);
                Sold6image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                return;
            }
            Score_Highscore_Currency_Manager.Instance.SpendDiamonds(buyBtn6Cost);
            Show();
            buyText.text = " Succesfully Purchased ";
            Sold6image.gameObject.SetActive(true);
            buy6image.gameObject.SetActive(false);
            PlayerPrefs.SetInt("buy6Purchased", 1);
            PlayerPrefs.Save();
            SelectSprite(sprite6);
            Invoke("Hide", 2);
            return;
        });

        buy7Button.onClick.AddListener(() => {

            if (PlayerPrefs.GetInt("buy7Purchased", 0) == 1) //ya nikal dena agar bar bar buy krna hai toh playerpref sab me se
            {
                Show();
                buyText.text = "Already Purchased & Equiped";
                Sold7image.gameObject.SetActive(true);
                buy7image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                SelectSprite(sprite7);
                return;
            }
            if (Score_Highscore_Currency_Manager.Instance.diamonds < buyBtn7Cost)
            {
                Show();
                buyText.text = "Not Enough Diamonds ";
                buy7image.gameObject.SetActive(true);
                Sold7image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                return;
            }
            Score_Highscore_Currency_Manager.Instance.SpendDiamonds(buyBtn7Cost);
            Show();
            buyText.text = " Succesfully Purchased ";
            Sold7image.gameObject.SetActive(true);
            buy7image.gameObject.SetActive(false);
            PlayerPrefs.SetInt("buy7Purchased", 1);
            PlayerPrefs.Save();
            SelectSprite(sprite7);
            Invoke("Hide", 2);
            return;
        });

        buy8Button.onClick.AddListener(() => {

            if (PlayerPrefs.GetInt("buy8Purchased", 0) == 1) //ya nikal dena agar bar bar buy krna hai toh playerpref sab me se
            {
                Show();
                buyText.text = "Already Purchased & Equiped";
                Sold8image.gameObject.SetActive(true);
                buy8image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                SelectSprite(sprite8);
                return;
            }
            if (Score_Highscore_Currency_Manager.Instance.diamonds < buyBtn8Cost)
            {
                Show();
                buyText.text = "Not Enough Diamonds ";
                buy8image.gameObject.SetActive(true);
                Sold8image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                return;
            }
            Score_Highscore_Currency_Manager.Instance.SpendDiamonds(buyBtn8Cost);
            Show();
            buyText.text = " Succesfully Purchased ";
            Sold8image.gameObject.SetActive(true);
            buy8image.gameObject.SetActive(false);
            PlayerPrefs.SetInt("buy8Purchased", 1);
            PlayerPrefs.Save();
            SelectSprite(sprite8);
            Invoke("Hide", 2);
            return;
        });

        buy9Button.onClick.AddListener(() => {

            if (PlayerPrefs.GetInt("buy9Purchased", 0) == 1) //ya nikal dena agar bar bar buy krna hai toh playerpref sab me se
            {
                Show();
                buyText.text = "Already Purchased & Equiped";
                Sold9image.gameObject.SetActive(true);
                buy9image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                SelectSprite(sprite9);
                return;
            }
            if (Score_Highscore_Currency_Manager.Instance.diamonds < buyBtn9Cost)
            {
                Show();
                buyText.text = "Not Enough Diamonds ";
                buy9image.gameObject.SetActive(true);
                Sold9image.gameObject.SetActive(false);
                Invoke("Hide", 2);
                return;
            }
            Score_Highscore_Currency_Manager.Instance.SpendDiamonds(buyBtn9Cost);
            Show();
            buyText.text = " Succesfully Purchased ";
         
            PlayerPrefs.SetInt("buy9Purchased", 1);

            PlayerPrefs.Save();
            SelectSprite(sprite9);
            Sold9image.gameObject.SetActive(true);
            buy9image.gameObject.SetActive(false);
            Invoke("Hide", 2);
            return;
        });
        containerShipImage1.sprite = sprite1;
        containerShipImage2.sprite = sprite2;
        containerShipImage3.sprite = sprite3;
        containerShipImage4.sprite = sprite4;
        containerShipImage5.sprite = sprite5;
        containerShipImage6.sprite = sprite6;
        containerShipImage7.sprite = sprite7;
        containerShipImage8.sprite = sprite8;
        containerShipImage9.sprite = sprite9;



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



    void SelectSprite(Sprite sprite)
    {
        selectedSpriteAsset.shipSprite = sprite;

    }
}
