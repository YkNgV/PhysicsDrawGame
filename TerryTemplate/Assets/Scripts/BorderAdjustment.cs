using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderAdjustment : MonoBehaviour
{
    public GameObject border;
    public Camera mainCam;

    private void Start()
    {
        scaleBorder();
    }

    private void scaleBorder()
    {
        Vector2 screenRes = new Vector2(Screen.width, Screen.height);

        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        float screenAspect = Screen.width / Screen.height; //obtain aspect ratio

        mainCam.aspect = screenAspect; //set aspect ratio

        float camHeight = 100.0f * mainCam.orthographicSize * 2.0f;
        float camWidth = camHeight * screenAspect; 




    }

}
