using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntegerScoreManager : MonoBehaviour {

    Text text1;
    void Start()
    {

        text1 = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        int newScore = JavaTarget.integerTotal;

        text1.text = "Integer: " + newScore;
    }
}
