using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UserName : MonoBehaviour
{

    public static UserName instance;

    [SerializeField] TMP_Text Obj_Text;
    public  TMP_InputField display;
    [SerializeField] Button okButton;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        Obj_Text.text = PlayerPrefs.GetString("user_name");
        okButton.onClick.AddListener(() =>
        {
            Back();
        });

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Create()
    {
        Obj_Text.text = display.text;
        PlayerPrefs.SetString("user_name" , Obj_Text .text);
        PlayerPrefs.Save();
    }
    private void Back()
    {
        gameObject.SetActive(false);
    }
}
