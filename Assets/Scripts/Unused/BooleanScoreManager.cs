using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BooleanScoreManager : MonoBehaviour {

    Text text;

    void Start()
    {

        text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        int newScore = JavaTarget.booleanTotal;

        text.text = "Boolean: " + newScore;
    }
}
