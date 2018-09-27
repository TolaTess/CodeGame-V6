
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Text playerDisplay;

    private void Start()
    {
        if (DatabaseManager.loggedIn)

            playerDisplay.text = DatabaseManager.username;
    }

    /// <summary>
    /// call next scene
    /// </summary>
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GameQuit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }


}
