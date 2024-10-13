using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.PlayerSettings;

public class Coin_Spawner : MonoBehaviour
{
    public GameObject Coin;
 

    void Start()
    {
        StartCoroutine(CoinSpawner());


    }

    // Update is called once per frame
    void Update()
    {

    }
    void CoinSpawm()
    {

       
        float rand = Random.Range(  -1.1f, 1.37f);
        Instantiate(Coin, new Vector3(rand, transform.position.y, transform.position.z), Quaternion.identity);
         
    }
    IEnumerator CoinSpawner()
    {
        while (true)
        {
            int time = Random.Range(10, 20);
            yield return new WaitForSeconds(2f);
            CoinSpawm();
        }

    }
    
}
