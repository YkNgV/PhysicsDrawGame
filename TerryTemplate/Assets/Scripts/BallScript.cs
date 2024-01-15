using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    Rigidbody2D rb;
    public NewAchievementManager achievement;

    // Start is called before the first frame update
    void Start()
    {
        achievement = FindObjectOfType<NewAchievementManager>();
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>())
        {
            rb.isKinematic = false;
        }

        //if(collision.gameObject.name == "Win Condition")
        //{
        //    Debug.Log("win detected");
        //    achievement.LevelCleared();
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Win Condition")
        {
            Debug.Log("win detected");
            achievement.LevelCleared();
        }
    }
}
