using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawn : MonoBehaviour
{

    public GameObject[] car;
    public float speed = 0.1f;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpwanCars());


    }

    // Update is called once per frame
    void Update()
    {

    }
    void Cars()
    {

        int rend = Random.Range(0, car.Length);
        float randXpos = Random.Range(-1.4f, 1.52f);
        Instantiate(car[rend], new Vector3(randXpos, transform.position.y, transform.position.z), Quaternion.identity);
    }
    IEnumerator SpwanCars()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            Cars();
        }

    }
}
