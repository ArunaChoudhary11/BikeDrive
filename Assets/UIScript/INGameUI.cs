using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class INGameUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coin;
    [SerializeField] TextMeshProUGUI Daimond;
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI highscore;



    int scores;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        coin.text = Score_Highscore_Currency_Manager.Instance.coins.ToString();
        score.text = Score_Highscore_Currency_Manager.Instance.score.ToString();
        Daimond.text = Score_Highscore_Currency_Manager.Instance.diamonds.ToString();
        highscore.text = Score_Highscore_Currency_Manager.Instance.highscore.ToString();    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
