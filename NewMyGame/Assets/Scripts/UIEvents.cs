﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIEvents : MonoBehaviour

{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }
}

