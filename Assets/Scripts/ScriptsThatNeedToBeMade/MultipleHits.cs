using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MultipleHits : MonoBehaviour
{
    //public Slider hungerSlider;
    public int amountToBeFed;
    private int currentFedAmount = 0;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

       // hungerSlider.maxValue = amountToBeFed;
       // hungerSlider.value = 0;
        //hungerSlider.fillRect.gameObject.SetActive(false);


        
    }


    // Update is called once per frame
    void Update()
    {


    }


    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        //hungerSlider.value = currentFedAmount;
        //hungerSlider.fillRect.gameObject.SetActive(true);


        if(currentFedAmount >= amountToBeFed)
        {
            gameManager.AddScore(amountToBeFed);
            Destroy(gameObject, 0.1f);
        }


    }
     
}
