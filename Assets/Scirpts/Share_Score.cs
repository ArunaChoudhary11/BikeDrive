using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Purchasing;
 
 


public class Share_Score : MonoBehaviour
{
    int highScore = 0;
    string appName  ;
    string message;
    string link;

    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sharescore()
    {
        appName = "street Racing 2D";
        link = "https://www.youtube.com/";
        message = "I Scored a New HighScore of" + highScore.ToString()  + "in" + appName + "./n/nTry to beat my HighScore in this Game:/n/nhere is the link " +link ;
        StartCoroutine(TakeScreenShotAndShare());
    }
    private IEnumerator TakeScreenShotAndShare()
    {
        yield return  new WaitForEndOfFrame();

        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0 , 0 , Screen.width , Screen.height) , 0 ,0 );
        ss.Apply();

        string filePath = Path.Combine(Application.temporaryCachePath, "shared img.png");
        File.WriteAllBytes(filePath , ss.EncodeToPNG() );   
        Destroy( ss );

       // new NativeShare().AddFile(filePath).SetSubject(appName).setText(message).Share();
    }
}
