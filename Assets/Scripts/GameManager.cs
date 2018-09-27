
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool hasEnded = false;
    public GameObject endGameMessage;

	public void GameOver()
    {
        if(hasEnded == false)
        {
            hasEnded = true;
            Debug.Log("Game has ended");
            AudioListener.volume = 0.1f;
            Time.timeScale = 0f;
            AudioListener.volume = 0f;
            endGameMessage.SetActive(true);

        }

    }

    public void Restart()
    {
        endGameMessage.SetActive(false);
        Time.timeScale = 1f;
        AudioListener.volume = 0.135f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
