using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartUI : MonoBehaviour {

    public bool hasEnded = false;
    public GameObject endGameMessage;

    public void GameOver()
    {
        if (hasEnded == false)
        {
            hasEnded = true;
            Debug.Log("Game has ended");
            AudioListener.volume = 0.1f;
            Time.timeScale = 0;
            AudioListener.volume = 0;
            endGameMessage.SetActive(true);
        }

    }

    public void Restart()
    {
      
            Debug.Log("Game has restarted");
            Time.timeScale = 1;
            AudioListener.volume = 1;
            SceneManager.LoadScene(1);
            endGameMessage.SetActive(false);
    }

}
