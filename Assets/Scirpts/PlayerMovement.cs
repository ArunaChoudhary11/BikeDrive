using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
   public static PlayerMovement instance;

    public float speed = 0.5f;
    public float rotationSpeed = 5f;

    public ScoreManager scoreValue;

    public GameObject gameOverPanel;
    [SerializeField] GameObject gamePauseButton;
   
    private bool isMovingLeft = false;
    private bool isMovingRight = false;

    [SerializeField] float halfWidth;

    bool isAlive = false;


    void Start()
    {

        gameOverPanel.SetActive(false);
        Time.timeScale = 1;

        halfWidth = Screen.width / 2;

      
    }



    float timer;
    void Update()
    {
        timer += Time.deltaTime;
        if (isAlive)
        {
           if(timer >= 0.5f)
            {
                Score_Highscore_Currency_Manager.Instance.score++;
                
                timer = 0;
            }
        }
        Movement();
        Clamp();

        if (Input.GetMouseButtonDown(0))
        {
            
            if (Input.mousePosition.x > halfWidth)
            {
                MoveRight();
            }
            else
            {
                MoveLeft();
            }
           
        }
        if (Input.GetMouseButtonUp(0))
        {
            StopMoving();
        }
    }

    void Movement()
    {
        
        if (isMovingRight)
        {
            isAlive = true;
          
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -40), rotationSpeed * Time.deltaTime);
        }

        if (isMovingLeft)
        {
            isAlive = true;
            
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 40), rotationSpeed * Time.deltaTime);
        }

        if (transform.rotation.z != 90)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), 10f * Time.deltaTime);
        }



    }
    

    void Clamp()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -2.0f, 2.0f);
        transform.position = pos;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boat" || collision.gameObject.tag == "Rock")
        {
            isAlive = false;
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
           
            Score_Highscore_Currency_Manager.Instance.TotalCoins(Score_Highscore_Currency_Manager.Instance.coins);
            gamePauseButton.SetActive(false);
        }
        if (collision.gameObject.tag == "Coin")
        {
             
            Score_Highscore_Currency_Manager.Instance.coins++;
            Destroy(collision.gameObject);
          
        }

        if(collision.transform.TryGetComponent(out Diamond diamond))
        {
            Score_Highscore_Currency_Manager.Instance.diamonds++;
           Score_Highscore_Currency_Manager.Instance.DiamondSave(Score_Highscore_Currency_Manager.Instance.diamonds);
            Destroy(collision.gameObject);
           
        }
    }

    public void MoveLeft()
    { 
        isMovingLeft = true;
        isMovingRight = false;
    }

    public void MoveRight()
    {
       
        isMovingRight = true;
        isMovingLeft = false;
    }

    public void StopMoving()
    {
        
        isMovingLeft = false;
        isMovingRight = false;
    }
}
