﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScoreManager : MonoBehaviour {

    public static int score;

    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {

        //total sore
 
        text.text = "Score: " + score;
      
	}
}
