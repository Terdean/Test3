﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        Application.LoadLevel("Plot");

    }

    public void Exit()
    {
        Application.Quit();
    }
}
