using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class CarsMOve : MonoBehaviour
{

   // public Transform transform;
    public float speed = 0.1f;
    public float time;
    private int x;

    [SerializeField] AudioClip BtnClip;

    // Start is called before the first frame update
    void Start()
    {
        //  transform = GetComponent<Transform>();

        x = 10;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3( 0 , speed*Time.deltaTime  , 0);
        inSpeed();

        if (transform.position.y <= -10)
        {
            SoundManager.Instance.PlaySound(BtnClip);
            Destroy(gameObject);
           
        }
    }
    void inSpeed()
    {
        time += Time.deltaTime;

        if (time > x)
        {
            speed -= 0.5f;
            x += 40;
        }
    }

}
