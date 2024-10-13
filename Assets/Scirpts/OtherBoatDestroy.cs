using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBoatDestroy : MonoBehaviour
{
  //  private float delay = 0.3f;
    public GameObject anima;
    
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
      
 
        if (collision.gameObject.tag == "Rock")
        {
           

              GameObject blastEffct = Instantiate(anima, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.3f);
            Destroy(blastEffct , 1f);
           


        }
    }
}
