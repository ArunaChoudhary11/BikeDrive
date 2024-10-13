using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaimondSwa : MonoBehaviour
{
    public GameObject Daimond;


    void Start()
    {
        StartCoroutine(DaimondSpawner());


    }

    // Update is called once per frame
    void Update()
    {

    }
    void DaimondSpawm()
    {


        float rand = Random.Range(-1.1f, 1.37f);
        Instantiate(Daimond, new Vector3(rand, transform.position.y, transform.position.z), Quaternion.identity);

    }
    IEnumerator DaimondSpawner()
    {
        while (true)
        {
            int time = Random.Range(40 , 60);
            yield return new WaitForSeconds(20f);
            DaimondSpawm();
        }

    }

}


