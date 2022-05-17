using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VideoStickman : MonoBehaviour
{

    public GameObject Video;
    public GameObject Video2;
    public double length;

    void Start()
    {
        Video.SetActive(true);
        Video2.SetActive(false);
    }

    public void stopVideo()
    {
        if(Video != null)
        {
            Video.SetActive(false);
           // Video.length(Video);
        }
        else 
            Video2.SetActive(true);
        //Video2.Length(Video2);
    }








    /*public void OpenVideo()
    {
       
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            bool isActive = Video.activeSelf;
            Video.SetActive(!isActive);
        

    }*/
}
