using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitch : MonoBehaviour
{

    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
        {
            if(other.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene(sceneName);
            }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
