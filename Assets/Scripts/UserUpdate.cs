using System.Collections;
using UnityEngine;

public class UserUpdate : MonoBehaviour {

    string URL = "http://localhost/codegame/userUpdate.php";
 

    // Update is called once per frame
    public void CallUpdate()
    {
        StartCoroutine(UpdateDetails());
    }

    IEnumerator UpdateDetails()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", DatabaseManager.username);
        form.AddField("score", DatabaseManager.score);
        WWW www = new WWW(URL, form);

        yield return www;
        if (www.error != null)
        {
            
            Debug.Log("User update failed #" + www.error);
        }
        else
        {
            Debug.Log("User details was updated #" + www.text);

            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }

    }

}
