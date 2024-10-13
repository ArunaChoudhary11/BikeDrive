using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMoveMent : MonoBehaviour
{

    public float speed = 0.1f;
    public Renderer meshRenderer;
    public float time;
    private int x;
    int screenWidth;
   [SerializeField] Camera myCamera;
     public static float worldWidth;

    // Start is called before the first frame update
    void Start()
    {
        x = 10;
        float aspect = (float)Screen.width / Screen.height;

        float worldHeight = myCamera.orthographicSize * 2;

         worldWidth = worldHeight * aspect;
        transform.localScale = new Vector3(worldWidth, 14.924f, 1.42f);


    }

    // Update is called once per frame
    void Update()
    {
      //  Vector2 offset = meshRenderer.material.mainTextureOffset;
      //  offset = offset + new Vector2(0 , speed *Time.deltaTime);

     //  meshRenderer.material.mainTextureOffset = offset;

        meshRenderer.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);
        inSpeed();
    }
    void inSpeed()
    {
        time += Time.deltaTime;

        if(time > x ) 
        {
            speed += 0.1f; 
            x += 10;
         }
    }
}
