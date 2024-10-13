using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UsernaeInput : MonoBehaviour
{
    public static UsernaeInput instance;

    public TMP_InputField userName;
    [SerializeField] string menuUsername;
    [SerializeField] Transform LoginPanel;

    [SerializeField] Transform UserPanel;
    [SerializeField] Transform MainMenu;
   
  

    public const string UsernameKey = "Username";
   

    [Header("Avatar Slection")]
    [SerializeField] Image[] selectedAvatar;
    [SerializeField] Transform avatarPanel;
    [SerializeField] Sprite[] avatarSprite;
    [SerializeField] Button[] avatarButton;
    private const string AvatarIndexKey = "AvatarIndex";
    [SerializeField] TextMeshProUGUI avatarText;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }



        if (PlayerPrefs.HasKey(UsernameKey))
        {

            menuUsername = PlayerPrefs.GetString(UsernameKey);
            MainMenu.gameObject.SetActive(true);
               UserPanel.gameObject.SetActive(false);
              //  WelcomeBackPanel.gameObject.SetActive(true);
               

        }
        else
        {
            LoginPanel.gameObject.SetActive(true);
          
        }


        if (PlayerPrefs.HasKey(AvatarIndexKey))
        {
            int avatarIndex = PlayerPrefs.GetInt(AvatarIndexKey);
            DisplaySelectedAvatar(avatarIndex);

        }

    }

    private void FixedUpdate()
    {
        AssignAvatarButtons();
    }
    private void AssignAvatarButtons()
    {  
        for (int i = 0; i < avatarButton.Length; i++)
        {

            int index = i;

            avatarButton[i].GetComponent<Image>().sprite = avatarSprite[index];


            avatarButton[i].onClick.AddListener(() => SelectAvatar(index));
        }
    }

    public void SelectAvatar(int index)
    {

        PlayerPrefs.SetInt(AvatarIndexKey, index);
        PlayerPrefs.Save();


        DisplaySelectedAvatar(index);

        avatarPanel.gameObject.SetActive(false);
        LoginPanel.gameObject.SetActive(true);

    }

    private void DisplaySelectedAvatar(int index)
    {
        if (index >= 0 && index < avatarSprite.Length)
        {
            for (int i = 0; i < selectedAvatar.Length; i++)
            {

                
                    selectedAvatar[i].sprite = avatarSprite[index];
                
            }
        }
        else
        {
            Debug.LogWarning("Avatar index out of range!");
        }
    }

    public void SaveUserName()
    {
        string enterUsername = userName.text;

        if (!string.IsNullOrEmpty(enterUsername))
        {
            if (PlayerPrefs.HasKey(AvatarIndexKey))
            {

            PlayerPrefs.SetString(UsernameKey, enterUsername);
            PlayerPrefs.Save();
            CloseUserPanel();
            }
            else
            {
                avatarText.text = "Please Select Avatar ";

            }

           /* if (selectedAvatar == null)
            {
                return;
            }*/



        }
        else
        {
           
        }


    }

    public void CloseUserPanel()
    {
        UserPanel.gameObject.SetActive(false);
        MainMenu.gameObject.SetActive(true);

    }

    public void avatarSelect()
    {
        if(string.IsNullOrEmpty(AvatarIndexKey))
         {
            PlayerPrefs.Save();




            CloseUserPanel();
        }
        else
        {

        }

        avatarPanel.gameObject.SetActive(true);
        LoginPanel.gameObject.SetActive(false);

    }



    // Update is called once per frame
    void Update()
    {



    }
}
