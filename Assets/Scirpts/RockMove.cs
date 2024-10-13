using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMove : MonoBehaviour
{
    // public Transform transform;
    public float speed = 0.1f;
    public float time;
    private int x;
    public float y;


    // Start is called before the first frame update
    void Start()
    {
        //  transform = GetComponent<Transform>();
        x = 10;


    }

    // Update is called once per frame
    void Update()
    {
        inSpeed();
        transform.position -= new Vector3(0, speed * Time.deltaTime, 0);

        if (transform.position.y <= -10)
        {
            Destroy(gameObject);
        }
    }
    void inSpeed()
    {
        time += Time.deltaTime;

        if (time > x)
        {
            speed += y;
            x += 10;
        }
    }
}
