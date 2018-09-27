
using UnityEngine;

public class PausedUI : MonoBehaviour {

    public static bool isPaused = false;
    public GameObject pauseUI;


	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.M))
        {
            if(isPaused)
            {
                Resume();
            }
            else
            {
              Pause();
            }
        }
	}

    public void Resume()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
}
