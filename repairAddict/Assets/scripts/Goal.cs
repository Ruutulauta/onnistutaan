using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    scoreManager scoreManager;
    //private int tulos;
    //public GameObject scoreKeeper;

    //public GameObject scoreHolder;

    void Start()
    {
        //tulos = scoreKeeper.GetComponent<scoreManager>().score;
    }

    void Awake()
    {
        scoreManager = gameObject.GetComponent<scoreManager>();
    }

    /*void tarkastaTulos()
    {
        tulos = scoreManager.GetComponent<scoreManager>().score;
    }*/

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject hitObj = collider.gameObject;
        if(hitObj.tag == "Player")
        {
            //Debug.Log("");
            /*if(scoreManager.score <= 6)
            {
                Debug.Log("kerää enemmän");
            }else{
                Debug.Log("Voitit");
            }*/
            
        }
    }
}
