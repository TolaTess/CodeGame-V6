using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class DatabaseManager {

    public static string username;
    public static int score;
    public static string text;

    public static bool loggedIn{ get { return username != null; }}

    public static void LogOut()
    {
        username = null;
    }

}
