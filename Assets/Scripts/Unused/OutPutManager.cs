using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;


public class OutPutManager : MonoBehaviour

{

    public Text text;
    string writePath;


    private void Start()
    {
        writePath = Application.dataPath + "/WriteText.txt";

        FindObjectOfType<ObjectManagerf>();

        FindObjectOfType<JavaTarget>();

        WritetoFile(writePath);

    }

    void WritetoFile(string filePath)
    {
        StreamWriter streamWriter;

        if (!File.Exists(filePath))
        {
            streamWriter = File.CreateText(Application.dataPath + "/WriteText.txt");
        }
        else

        {
            streamWriter = new StreamWriter(filePath);
        }

        for (int k = 0; k < ObjectManagerf.obj.Length; k++)
            {

            streamWriter.WriteLine(ObjectManagerf.obj[k]);
            DatabaseManager.text = ObjectManagerf.obj[k];

            }

        streamWriter.Close();
    }
}

