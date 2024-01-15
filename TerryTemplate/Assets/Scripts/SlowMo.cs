using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;
using UnityEngine.UI;

public class SlowMo : MonoBehaviour
{
    public Text multiplier;
    public bool currentlySlowed;

    DrawingManager drawManager;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        multiplier.text = "1.0x";

        drawManager = FindAnyObjectByType<DrawingManager>();
}

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeSpeed()
    {
        drawManager.drawCount--; //so it doesnt increase on click

        if (!currentlySlowed)
        {
            Time.timeScale = 0.5f;
            multiplier.text = "0.5x";
            currentlySlowed = true;
        }
        else if (currentlySlowed)
        {
            Time.timeScale = 1.0f;
            multiplier.text = "1.0x";
            currentlySlowed = false;
        }
    }
}
