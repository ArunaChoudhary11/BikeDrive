using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOption : MonoBehaviour
{
    [SerializeField] Transform shopPanel;
    [SerializeField] Transform diamondsBuyPanel;
    [SerializeField] Transform ad_FreePanel;
    [SerializeField] Transform mainMenuPanel;
    [SerializeField] Transform optionPanel;
    [SerializeField] Transform settingpanel;
   
 
    public void ShopPanel()
    {
        shopPanel.gameObject.SetActive(true);
        diamondsBuyPanel.gameObject.SetActive(false);
        ad_FreePanel.gameObject.SetActive(false);   
    }

    public void DaimondBuyPanel()
    {
        diamondsBuyPanel.gameObject.SetActive(true);
        shopPanel.gameObject.SetActive(false);
        ad_FreePanel.gameObject.SetActive(false);
    }
    
    public void ad_freePanel()
    {
        ad_FreePanel.gameObject.SetActive(true );
        shopPanel.gameObject.SetActive(false);
        diamondsBuyPanel.gameObject.SetActive(false);
    }

    public void mainMenu()
    {
        mainMenuPanel.gameObject.SetActive(true );
        optionPanel.gameObject.SetActive(false);
        ad_FreePanel.gameObject.SetActive(false);
        shopPanel.gameObject.SetActive(false);
       
        diamondsBuyPanel.gameObject.SetActive(false);
        settingpanel.gameObject.SetActive(false);
    }


}
