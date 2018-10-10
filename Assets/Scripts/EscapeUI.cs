﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeUI : MonoBehaviour {

    public static bool isInView = true;
    public GameObject canvas;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isInView)
            {
                Hide();
            }
        }
    }

    public void Hide()
    {
        canvas.SetActive(false);
        isInView = false;
    }
}