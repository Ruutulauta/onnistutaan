using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public scoreManager scoreManager;
    public int tulos;

    //public GameObject scoreHolder;

    void Start()
    {
        if(tulos == null)
        {
            tulos = scoreManager.GetComponent<scoreManager>().score;
        }
        
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
            Debug.Log("kerätty " + tulos);
            /*if(scoreManager.score <= 6)
            {
                Debug.Log("kerää enemmän");
            }else{
                Debug.Log("Voitit");
            }*/
            
        }
    }
}
