using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinCounter : MonoBehaviour
{
    
    public int coinCount;
    public Text coinText;
   



    private void Awake()
    {
         
    }
    // Start is called before the first frame update
    void Start()
    {
         
      
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = coinCount.ToString();
        
    }

    
}
