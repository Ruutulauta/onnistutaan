using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class gameover : MonoBehaviour
{

    public string retryScene;
    public string toMainScene;

    public void retrygame()
    {
        SceneManager.LoadScene(retryScene);
    }
    public void tomainmenu()
    {
        SceneManager.LoadScene(toMainScene);
    }
}
