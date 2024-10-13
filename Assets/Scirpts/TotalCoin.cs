using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalCoin : MonoBehaviour
{
    public coinCounter cc;
    public int ToTalCoin;
    public Text TotalCoinText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TotalCoinA()
    {
        ToTalCoin = PlayerPrefs.GetInt("TotalCoin", 0);
        ToTalCoin += cc.coinCount;

        PlayerPrefs.SetInt("TotalCoin", ToTalCoin);
     
        PlayerPrefs.SetInt("TotalCoin", ToTalCoin);
    }
}
