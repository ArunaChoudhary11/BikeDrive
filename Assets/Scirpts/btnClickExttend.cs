using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnClickExttend : MonoBehaviour
{
    public Button onClickBike;
    public GameObject shopbtn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void btnCLick()
    {
        if (onClickBike != null)
        {
            shopbtn.GetComponent<RectTransform>().sizeDelta += new Vector2(150,520);
        }
    }
}
