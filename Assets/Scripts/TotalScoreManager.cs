﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScoreManager : MonoBehaviour {
    

    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
        int newScore = JavaTarget.score;

 
        text.text = "Score: " + newScore;
      
	}
}