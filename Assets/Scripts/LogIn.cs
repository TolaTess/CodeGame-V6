using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogIn : MonoBehaviour {

    string URL = "http://localhost/codegame/userSelect.php";
    public string[] userData;
    public string[] loginData;
    public InputField usernameField;
    public InputField passwordField;

    public Button submitButton;

    /// <summary>
    /// use courotiner to call ienumerator method
    /// </summary>
    public void CallLogin()
    {
        LoginPlayer();
    }
    public void VerifyInput()
    {
        submitButton.interactable = (usernameField.text.Length >= 6 && passwordField.text.Length >= 6);
    }


    IEnumerator Start()
    {

        WWW users = new WWW(URL);
        yield return users;
        string usersDataString = users.text;
        userData = usersDataString.Split(';');

    }

    /// <summary>
    /// login method to assess php server and store user details
    /// </summary>
    /// <returns>The login.</returns>
    void LoginPlayer() 
    {
        for (int i = 0; i < userData.Length-1; i++)
        {
            if ((userData[i].Contains(usernameField.text)) && (userData[i].Contains(passwordField.text)))
                {      
                    UnityEngine.SceneManagement.SceneManager.LoadScene(1);
                    DatabaseManager.username = usernameField.text;
                    GetScore(userData[i]);   
                }
        }
    }

    public void GetScore(string data)
    {
        loginData = data.Split('|');
        for (int j = 0; j < loginData.Length; j++)
            {
            if (loginData[j].Contains("score:"))
            {
                string scoreData = loginData[j].Replace("score:", "");
                int score = int.Parse(scoreData);
                DatabaseManager.score = score;
            }

        }
    }

}
