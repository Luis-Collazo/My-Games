using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player 1"))
        {
           Destroy(gameObject);
            Destroy(other.gameObject);
            ScoreScript.scoreValue += 1;
        }

       if (other.CompareTag("Player 2"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            ScoreScript.scoreValue += 1;
        }

        //if (other.CompareTag("Player"))
        //{
         //gameManager.AddLives(-1);
        // Destroy(gameObject);
        //}
        else if (other.CompareTag("Enemy"))
        {
            //other.GetComponent<MultipleHits>().FeedAnimal(1);
            //gameManager.AddScore(1);
            //Destroy(gameObject);
            Destroy(gameObject);
        }

        if (other.CompareTag("Player 1"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }

        if (other.CompareTag("Player 2"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }


    }

    
}
