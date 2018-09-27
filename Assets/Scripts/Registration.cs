using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour {

    string URL = "http://localhost/codegame/userInsert.php";
    public InputField usernameField;
    public InputField emailField;
    public InputField passwordField;

    public Button submitButton;
    /// <summary>
    /// Calls the register method.
    /// </summary>
    public void CallRegister()
    {
        
        StartCoroutine(Register());
       
    }

    public void VerifyInput()

    {
       
        submitButton.interactable = (usernameField.text.Length >= 6 && emailField.text.Length >= 6 && passwordField.text.Length >= 6);

    }
    /// <summary>
    /// Register method to post user's details in php server
    /// </summary>
    /// <returns>The register.</returns>
    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("addUsername", usernameField.text);
        form.AddField("addEmail", emailField.text);
        form.AddField("addPassword", passwordField.text);
        WWW www = new WWW(URL, form);
        //WWW www = new WWW("http://localhost:9000/register.php", form);

        yield return www;
        if (www.error != null)
        {

            Debug.Log("User Creation failed. Error # " + www.error);
        }
        else
        {
            Debug.Log("User created sucessfully." + www.text);

            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
            DatabaseManager.username = usernameField.text;
        }
    }
}
