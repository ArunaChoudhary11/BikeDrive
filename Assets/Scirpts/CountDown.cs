using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countdownText;
    private float countdownTimer = 3.0f;
    private bool countdownActive = true;
    [SerializeField] Transform countDownTextGameObject;
   // [SerializeField] Transform spawnCarActive;

    private void Start()
    {
     
        
    }

    void Update()
    {
        if (countdownActive)
        {
            countdownTimer -= Time.deltaTime;
            int timer = Mathf.CeilToInt(countdownTimer);

            if (timer > 0)
            {
                countdownText.text = timer.ToString();
            }
            else if (countdownTimer > 0)
            {
                countdownText.text = "Go!";
               
            }
            else
            {
                countDownTextGameObject.gameObject.SetActive(false);
                countdownActive = false;
            }
        }
    }
}
