using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mutteri : MonoBehaviour
{
    public int mutteriValue = 1;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            scoreManager.instance.ChangeScore(mutteriValue);
        }
    }
}
