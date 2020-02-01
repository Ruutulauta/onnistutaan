using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public static scoreManager instance;
    public TextMeshProUGUI text;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int mutteriValue)
    {
        score += mutteriValue;
        text.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
