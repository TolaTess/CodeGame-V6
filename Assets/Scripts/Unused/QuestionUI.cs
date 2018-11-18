using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionUI : MonoBehaviour {

    public static bool isInView = false;
    public GameObject questions;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (isInView)
            {
                Show();
            }
            else
            {
                Hide();
            }
        }
    }

    public void Show()
    {
        questions.SetActive(false);
        isInView = false;
    }

    public void Hide()
    {
        questions.SetActive(true);
        isInView = true;
    }

}
