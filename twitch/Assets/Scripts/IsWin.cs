using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsWin : MonoBehaviour
{
    public int red;
    public int yellow;
    public static string Winner;
    void Start()
    {
        red = 0;
        yellow = 0;
    }

    void Update()
    {
        if (red == 4)
        {
            Winner = "Streamer";
            print("Streamer Win");
        }
        if (yellow == 4)
        {
            Winner = "Twitch Chat";
            print("Chat Win");
        }
        if (Puissance_4.Restart == true)
        {
            WinReset();
            Puissance_4.Restart = false;
            Winner = "";
        }
    }
    public void OnTriggerEnter(Collider coins)
    {
        if (coins.gameObject.tag == "Red")
        {
            red++;
        }
        if (coins.gameObject.tag == "Yellow")
        {
            yellow++;
        }
    }

    public void WinReset()
    {
        red = 0;
        yellow = 0;
    }
}
