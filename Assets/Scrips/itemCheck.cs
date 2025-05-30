using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCheck : MonoBehaviour
{
    public int score;
    // public GameObject ScoreObject;
    Text scoreText;

    private void Start()
    {
        // scoreText = ScoreObject.GetComponent<Text>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag != "Good")
        {
            score -= 1;
            // scoreText.text = score.ToString();
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
