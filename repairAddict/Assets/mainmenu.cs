﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public string sceneName;

   public void playgame()
    {
        SceneManager.LoadScene(sceneName);
    }
}
