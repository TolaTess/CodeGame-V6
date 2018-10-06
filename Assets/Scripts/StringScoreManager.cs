using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StringScoreManager : MonoBehaviour {

    Text text;


    void Start()
    {

        text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        int newScore = JavaTarget1.stringTotal;

        text.text = "String: " + newScore;

        if (JavaTarget1.stringTotal == 6)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
