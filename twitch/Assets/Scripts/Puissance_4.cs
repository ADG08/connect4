using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.ComponentModel;
using System.Net.Sockets;
using System.IO;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Puissance_4 : MonoBehaviour
{
    //initiate twitch channel
    private TcpClient twitchClient;
    private StreamReader reader;
    private StreamWriter writer;
    public  static string username, password, channelName; //Get the password from https://twitchapps.com/tmi

    //list of users
    string[] users = {};
    List<string> usersList = new List<string>();

    //list of users voting
    string[] case1 = {};
    List<string> Case1List = new List<string>();
    string[] case2 = {};
    List<string> Case2List = new List<string>();
    string[] case3 = { };
    List<string> Case3List = new List<string>();
    string[] case4 = { };
    List<string> Case4List = new List<string>();
    string[] case5 = { };
    List<string> Case5List = new List<string>();
    string[] case6 = { };
    List<string> Case6List = new List<string>();
    string[] case7 = { };
    List<string> Case7List = new List<string>();

    private float howManyVote;

    public TMP_Text puissance4Case1;
    public TMP_Text puissance4Case2;
    public TMP_Text puissance4Case3;
    public TMP_Text puissance4Case4;
    public TMP_Text puissance4Case5;
    public TMP_Text puissance4Case6;
    public TMP_Text puissance4Case7;
    public TMP_Text WinnerOfPuissance4Case;
    public TMP_Text NumberOfVotes;

    [SerializeField]
    public float timeToWait;
    public TMP_Text timer;
    public bool startCountdown;

    public GameObject c1L1;
    private bool C1L1;
    public GameObject c2L1;
    private bool C2L1;
    public GameObject c3L1;
    private bool C3L1;
    public GameObject c4L1;
    private bool C4L1;
    public GameObject c5L1;
    private bool C5L1;
    public GameObject c6L1;
    private bool C6L1;
    public GameObject c7L1;
    private bool C7L1;
    public GameObject c1L2;
    private bool C1L2;
    public GameObject c2L2;
    private bool C2L2;
    public GameObject c3L2;
    private bool C3L2;
    public GameObject c4L2;
    private bool C4L2;
    public GameObject c5L2;
    private bool C5L2;
    public GameObject c6L2;
    private bool C6L2;
    public GameObject c7L2;
    private bool C7L2;
    public GameObject c1L3;
    private bool C1L3;
    public GameObject c2L3;
    private bool C2L3;
    public GameObject c3L3;
    private bool C3L3;
    public GameObject c4L3;
    private bool C4L3;
    public GameObject c5L3;
    private bool C5L3;
    public GameObject c6L3;
    private bool C6L3;
    public GameObject c7L3;
    private bool C7L3;
    public GameObject c1L4;
    private bool C1L4;
    public GameObject c2L4;
    private bool C2L4;
    public GameObject c3L4;
    private bool C3L4;
    public GameObject c4L4;
    private bool C4L4;
    public GameObject c5L4;
    private bool C5L4;
    public GameObject c6L4;
    private bool C6L4;
    public GameObject c7L4;
    private bool C7L4;
    public GameObject c1L5;
    private bool C1L5;
    public GameObject c2L5;
    private bool C2L5;
    public GameObject c3L5;
    private bool C3L5;
    public GameObject c4L5;
    private bool C4L5;
    public GameObject c5L5;
    private bool C5L5;
    public GameObject c6L5;
    private bool C6L5;
    public GameObject c7L5;
    private bool C7L5;
    public GameObject c1L6;
    private bool C1L6;
    public GameObject c2L6;
    private bool C2L6;
    public GameObject c3L6;
    private bool C3L6;
    public GameObject c4L6;
    private bool C4L6;
    public GameObject c5L6;
    private bool C5L6;
    public GameObject c6L6;
    private bool C6L6;
    public GameObject c7L6;
    private bool C7L6;

    /// <summary>
    /// Red coins
    /// </summary>
    public GameObject c1L1Red;
    public GameObject c2L1Red;
    public GameObject c3L1Red;
    public GameObject c4L1Red;
    public GameObject c5L1Red;
    public GameObject c6L1Red;
    public GameObject c7L1Red;
    public GameObject c1L2Red;
    public GameObject c2L2Red;
    public GameObject c3L2Red;
    public GameObject c4L2Red;
    public GameObject c5L2Red;
    public GameObject c6L2Red;
    public GameObject c7L2Red;
    public GameObject c1L3Red;
    public GameObject c2L3Red;
    public GameObject c3L3Red;
    public GameObject c4L3Red;
    public GameObject c5L3Red;
    public GameObject c6L3Red;
    public GameObject c7L3Red;
    public GameObject c1L4Red;
    public GameObject c2L4Red;
    public GameObject c3L4Red;
    public GameObject c4L4Red;
    public GameObject c5L4Red;
    public GameObject c6L4Red;
    public GameObject c7L4Red;
    public GameObject c1L5Red;
    public GameObject c2L5Red;
    public GameObject c3L5Red;
    public GameObject c4L5Red;
    public GameObject c5L5Red;
    public GameObject c6L5Red;
    public GameObject c7L5Red;
    public GameObject c1L6Red;
    public GameObject c2L6Red;
    public GameObject c3L6Red;
    public GameObject c4L6Red;
    public GameObject c5L6Red;
    public GameObject c6L6Red;
    public GameObject c7L6Red;

    /// <summary>
    /// Yellow Coins
    /// </summary>
    public GameObject c1L1Yellow;
    public GameObject c2L1Yellow;
    public GameObject c3L1Yellow;
    public GameObject c4L1Yellow;
    public GameObject c5L1Yellow;
    public GameObject c6L1Yellow;
    public GameObject c7L1Yellow;
    public GameObject c1L2Yellow;
    public GameObject c2L2Yellow;
    public GameObject c3L2Yellow;
    public GameObject c4L2Yellow;
    public GameObject c5L2Yellow;
    public GameObject c6L2Yellow;
    public GameObject c7L2Yellow;
    public GameObject c1L3Yellow;
    public GameObject c2L3Yellow;
    public GameObject c3L3Yellow;
    public GameObject c4L3Yellow;
    public GameObject c5L3Yellow;
    public GameObject c6L3Yellow;
    public GameObject c7L3Yellow;
    public GameObject c1L4Yellow;
    public GameObject c2L4Yellow;
    public GameObject c3L4Yellow;
    public GameObject c4L4Yellow;
    public GameObject c5L4Yellow;
    public GameObject c6L4Yellow;
    public GameObject c7L4Yellow;
    public GameObject c1L5Yellow;
    public GameObject c2L5Yellow;
    public GameObject c3L5Yellow;
    public GameObject c4L5Yellow;
    public GameObject c5L5Yellow;
    public GameObject c6L5Yellow;
    public GameObject c7L5Yellow;
    public GameObject c1L6Yellow;
    public GameObject c2L6Yellow;
    public GameObject c3L6Yellow;
    public GameObject c4L6Yellow;
    public GameObject c5L6Yellow;
    public GameObject c6L6Yellow;
    public GameObject c7L6Yellow;

    public Color red;
    public Color yellow;

    public bool isPlayerTurn;

    public GameObject StreamerTurn;
    public GameObject ChatTurn;

    public GameObject StreamerChoose;
    public GameObject Timer;
    public TMP_InputField teste;
    public TMP_Text StreamerChooseText;
    public GameObject chatRound;

    public GameObject ChatWin;
    public GameObject StreamerWin;

    public GameObject WhoAreWinner;
    public bool GameEnd;
    public GameObject RestartGameChat;
    public GameObject stopGame;
    public GameObject NumberOfVotesUI;
    public GameObject WhoWin;
    public GameObject WinnerBack;

    private string WinnerOfRoundText;

    public static bool Restart;

    void Start()
    {
        Restart = false;
        Connect();
        usersList = new List<string>();
        usersList.AddRange(users);
        Case1List.AddRange(case1);
        timer.text = timeToWait.ToString();
        C1L1 = false;
        C2L1 = false;
        C3L1 = false;
        C4L1 = false;
        C5L1 = false;
        C6L1 = false;
        C7L1 = false;
        isPlayerTurn = false;
        ChatTurn.SetActive(true);
        StreamerTurn.SetActive(false);
        GameEnd = false;
        //Red Coins
        c1L1Red.SetActive(false);
        c2L1Red.SetActive(false);
        c3L1Red.SetActive(false);
        c4L1Red.SetActive(false);
        c5L1Red.SetActive(false);
        c6L1Red.SetActive(false);
        c7L1Red.SetActive(false);
        c1L2Red.SetActive(false);
        c2L2Red.SetActive(false);
        c3L2Red.SetActive(false);
        c4L2Red.SetActive(false);
        c5L2Red.SetActive(false);
        c6L2Red.SetActive(false);
        c7L2Red.SetActive(false);
        c1L3Red.SetActive(false);
        c2L3Red.SetActive(false);
        c3L3Red.SetActive(false);
        c4L3Red.SetActive(false);
        c5L3Red.SetActive(false);
        c6L3Red.SetActive(false);
        c7L3Red.SetActive(false);
        c1L4Red.SetActive(false);
        c2L4Red.SetActive(false);
        c3L4Red.SetActive(false);
        c4L4Red.SetActive(false);
        c5L4Red.SetActive(false);
        c6L4Red.SetActive(false);
        c7L4Red.SetActive(false);
        c1L5Red.SetActive(false);
        c2L5Red.SetActive(false);
        c3L5Red.SetActive(false);
        c4L5Red.SetActive(false);
        c5L5Red.SetActive(false);
        c6L5Red.SetActive(false);
        c7L5Red.SetActive(false);
        c1L6Red.SetActive(false);
        c2L6Red.SetActive(false);
        c3L6Red.SetActive(false);
        c4L6Red.SetActive(false);
        c5L6Red.SetActive(false);
        c6L6Red.SetActive(false);
        c7L6Red.SetActive(false);

        //Yellow coins
        c1L1Yellow.SetActive(false);
        c2L1Yellow.SetActive(false);
        c3L1Yellow.SetActive(false);
        c4L1Yellow.SetActive(false);
        c5L1Yellow.SetActive(false);
        c6L1Yellow.SetActive(false);
        c7L1Yellow.SetActive(false);
        c1L2Yellow.SetActive(false);
        c2L2Yellow.SetActive(false);
        c3L2Yellow.SetActive(false);
        c4L2Yellow.SetActive(false);
        c5L2Yellow.SetActive(false);
        c6L2Yellow.SetActive(false);
        c7L2Yellow.SetActive(false);
        c1L3Yellow.SetActive(false);
        c2L3Yellow.SetActive(false);
        c3L3Yellow.SetActive(false);
        c4L3Yellow.SetActive(false);
        c5L3Yellow.SetActive(false);
        c6L3Yellow.SetActive(false);
        c7L3Yellow.SetActive(false);
        c1L4Yellow.SetActive(false);
        c2L4Yellow.SetActive(false);
        c3L4Yellow.SetActive(false);
        c4L4Yellow.SetActive(false);
        c5L4Yellow.SetActive(false);
        c6L4Yellow.SetActive(false);
        c7L4Yellow.SetActive(false);
        c1L5Yellow.SetActive(false);
        c2L5Yellow.SetActive(false);
        c3L5Yellow.SetActive(false);
        c4L5Yellow.SetActive(false);
        c5L5Yellow.SetActive(false);
        c6L5Yellow.SetActive(false);
        c7L5Yellow.SetActive(false);
        c1L6Yellow.SetActive(false);
        c2L6Yellow.SetActive(false);
        c3L6Yellow.SetActive(false);
        c4L6Yellow.SetActive(false);
        c5L6Yellow.SetActive(false);
        c6L6Yellow.SetActive(false);
        c7L6Yellow.SetActive(false);
        Timer.SetActive(false);
        RestartGameChat.SetActive(false);
        ChatWin.SetActive(false);
        StreamerWin.SetActive(false);
        stopGame.SetActive(false);
        NumberOfVotesUI.SetActive(true);
        WhoWin.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        print(WinnerOfRoundText);
        print(howManyVote);
        print(username);
        print(password);
        if (GameEnd == false)
        {
            NumberOfVotesUI.SetActive(true);
            WhoWin.SetActive(true);
            RestartGameChat.SetActive(false);
            WinMessage();
            if (!twitchClient.Connected)
            {
                Connect();
            }
            if (isPlayerTurn == true)
            {
                Timer.SetActive(false);
                StreamerChoose.SetActive(true);
                chatRound.SetActive(false);
                StreamerTurn.SetActive(true);
                ChatTurn.SetActive(false);
                NumberOfVotes.text = "0";
            }
            else if (isPlayerTurn == false)
            {
                Timer.SetActive(true);
                if (startCountdown == false)
                {
                    chatRound.SetActive(true);
                }
                else
                    chatRound.SetActive(false);
                StreamerChoose.SetActive(false);
                StreamerTurn.SetActive(false);
                ChatTurn.SetActive(true);
            }

            if (startCountdown == true)
            {
                NumberOfVotes.text = howManyVote.ToString();
                if (isPlayerTurn == false)
                {
                    ReadChat();
                }
                timeToWait -= Time.deltaTime;
                timer.text = Mathf.Round(timeToWait).ToString();
                stopGame.SetActive(true);
                if (timeToWait <= 0)
                {
                    stopGame.SetActive(false);
                    Case1List = new List<string> { };
                    Case2List = new List<string> { };
                    Case3List = new List<string> { };
                    Case4List = new List<string> { };
                    Case5List = new List<string> { };
                    Case6List = new List<string> { };
                    Case7List = new List<string> { };
                    puissance4Case1.text = "!1";
                    puissance4Case2.text = "!2";
                    puissance4Case3.text = "!3";
                    puissance4Case4.text = "!4";
                    puissance4Case5.text = "!5";
                    puissance4Case6.text = "!6";
                    puissance4Case7.text = "!7";
                    timer.text = "0";
                    timeToWait = 30;
                    startCountdown = false;
                    howManyVote = 0;
                    CreateCoins();
                    WinnerOfRoundText = "";
                    WinnerOfPuissance4Case.text = "";
                    isPlayerTurn = !isPlayerTurn;
                }
            }
        }
        else if (GameEnd == true)
        {
            chatRound.SetActive(false);
            RestartGameChat.SetActive(true);
            StreamerChoose.SetActive(false);
            StreamerTurn.SetActive(false);
            ChatTurn.SetActive(false);
            Timer.SetActive(false);
            stopGame.SetActive(false);
            NumberOfVotesUI.SetActive(false);
            WhoWin.SetActive(false);
            puissance4Case1.text = "";
            puissance4Case2.text = "";
            puissance4Case3.text = "";
            puissance4Case4.text = "";
            puissance4Case5.text = "";
            puissance4Case6.text = "";
            puissance4Case7.text = "";
        }
    }
    public void RestartGame()
    {
        GameEnd = false;
        Restart = true;
        isPlayerTurn = false;
        NumberOfVotesUI.SetActive(true);
        WhoWin.SetActive(true);
        RestartGameChat.SetActive(false);
        ChatTurn.SetActive(true);
        StreamerTurn.SetActive(false);
        chatRound.SetActive(true);
        ChatWin.SetActive(false);
        StreamerWin.SetActive(false);
        WhoAreWinner.SetActive(false);
        WinnerBack.SetActive(false);
        WhoAreWinner.GetComponent<TextMeshProUGUI>().text = " ";
        SceneManager.LoadScene(1);
    }
    public void StartRound()
    {
        startCountdown = true;
        WinnerOfRoundText = "";
    }
    public void CreateCoins()
    {
        if (WinnerOfRoundText == "C1L1 gagne")
        {

            puissance4Case1.transform.position = new Vector3(140f, 300f, 0);
            if (isPlayerTurn == true)
            {
                c1L1Red.SetActive(true);
                c1L1.transform.gameObject.tag = "Red";
                c1L1.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c1L1Yellow.SetActive(true);
                c1L1.transform.gameObject.tag = "Yellow";
                c1L1.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            c1L1.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C1L1 = true;
            }
        }
        if (WinnerOfRoundText == "C1L2 gagne")
        {
            puissance4Case1.transform.position = new Vector3(140, 460f, 0);
            if (isPlayerTurn == true)
            {
                c1L2Red.SetActive(true);
                c1L2.transform.gameObject.tag = "Red";
                c1L2.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c1L2Yellow.SetActive(true);
                c1L2.transform.gameObject.tag = "Yellow";
                c1L2.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            c1L2.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C1L2 = true;
            }
        }
        if (WinnerOfRoundText == "C1L3 gagne")
        {
            puissance4Case1.transform.position = new Vector3(140f, 620f, 0);
            if (isPlayerTurn == true)
            {
                c1L3Red.SetActive(true);
                c1L3.transform.gameObject.tag = "Red";
                c1L3.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c1L3Yellow.SetActive(true);
                c1L3.transform.gameObject.tag = "Yellow";
                c1L3.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            c1L3.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C1L3 = true;
            }
        }
        if (WinnerOfRoundText == "C1L4 gagne")
        {
            puissance4Case1.transform.position = new Vector3(140f, 780f, 0);
            if (isPlayerTurn == true)
            {
                c1L4Red.SetActive(true);
                c1L4.transform.gameObject.tag = "Red";
                c1L4.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c1L4Yellow.SetActive(true);
                c1L4.transform.gameObject.tag = "Yellow";
                c1L4.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            c1L4.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C1L4 = true;
            }
        }
        if (WinnerOfRoundText == "C1L5 gagne")
        {
            puissance4Case1.transform.position = new Vector3(140f, 940f, 0);
            if (isPlayerTurn == true)
            {
                c1L5Red.SetActive(true);
                c1L5.transform.gameObject.tag = "Red";
                c1L5.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c1L5Yellow.SetActive(true);
                c1L5.transform.gameObject.tag = "Yellow";
                c1L5.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            c1L5.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C1L5 = true;
            }
        }
        if (WinnerOfRoundText == "C1L6 gagne")
        {
            Destroy(puissance4Case1);
            if (isPlayerTurn == true)
            {
                c1L6Red.SetActive(true);
                c1L6.transform.gameObject.tag = "Red";
                c1L6.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c1L6Yellow.SetActive(true);
                c1L6.transform.gameObject.tag = "Yellow";
                c1L6.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            c1L6.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C1L6 = true;
            }
        }

        if (WinnerOfRoundText == "C2L1 gagne")
        {
            puissance4Case2.transform.position = new Vector3(305f, 300f, 0);
            if (isPlayerTurn == true)
            {
                c2L1Red.SetActive(true);
                c2L1.transform.gameObject.tag = "Red";
                c2L1.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c2L1Yellow.SetActive(true);
                c2L1.transform.gameObject.tag = "Yellow";
                c2L1.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c2L1.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C2L1 = true;
            }
        }
        if (WinnerOfRoundText == "C2L2 gagne")
        {
            puissance4Case2.transform.position = new Vector3(305, 460, 0);
            if (isPlayerTurn == true)
            {
                c2L2Red.SetActive(true);
                c2L2.transform.gameObject.tag = "Red";
                c2L2.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c2L2Yellow.SetActive(true);
                c2L2.transform.gameObject.tag = "Yellow";
                c2L2.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
           
            c2L2.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C2L2 = true;
            }
        }
        if (WinnerOfRoundText == "C2L3 gagne")
        {
            puissance4Case2.transform.position = new Vector3(305, 620, 0);
            if (isPlayerTurn == true)
            {
                c2L3Red.SetActive(true);
                c2L3.transform.gameObject.tag = "Red";
                c2L3.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c2L3Yellow.SetActive(true);
                c2L3.transform.gameObject.tag = "Yellow";
                c2L3.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            c2L3.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C2L3 = true;
            }
        }
        if (WinnerOfRoundText == "C2L4 gagne")
        {
            puissance4Case2.transform.position = new Vector3(305, 780, 0);
            if (isPlayerTurn == true)
            {
                c2L4Red.SetActive(true);
                c2L4.transform.gameObject.tag = "Red";
                c2L4.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c2L4Yellow.SetActive(true);
                c2L4.transform.gameObject.tag = "Yellow";
                c2L4.gameObject.GetComponent<Renderer>().material.color = yellow;

            }
            c2L4.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C2L4 = true;
            }
        }
        if (WinnerOfRoundText == "C2L5 gagne")
        {
            puissance4Case1.transform.position = new Vector3(305, 940, 0);
            if (isPlayerTurn == true)
            {
                c2L5Red.SetActive(true);
                c2L5.transform.gameObject.tag = "Red";
                c2L5.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c2L5Yellow.SetActive(true);
                c2L5.transform.gameObject.tag = "Yellow";
                c2L5.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c2L5.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C2L5 = true;
            }
        }
        if (WinnerOfRoundText == "C2L6 gagne")
        {
            Destroy(puissance4Case2);
            if (isPlayerTurn == true)
            {
                c2L6Red.SetActive(true);
                c2L6.transform.gameObject.tag = "Red";
                c2L6.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c2L6Yellow.SetActive(true);
                c2L6.transform.gameObject.tag = "Yellow";
                c2L6.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
           
            c2L6.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C2L6 = true;
            }
        }

        if (WinnerOfRoundText == "C3L1 gagne")
        {
            puissance4Case3.transform.position = new Vector3(475, 300, 0);
            if (isPlayerTurn == true)
            {
                c3L1Red.SetActive(true);
                c3L1.transform.gameObject.tag = "Red";
                c3L1.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c3L1Yellow.SetActive(true);
                c3L1.transform.gameObject.tag = "Yellow";
                c3L1.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c3L1.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C3L1 = true;
            }
        }
        if (WinnerOfRoundText == "C3L2 gagne")
        {
            puissance4Case3.transform.position = new Vector3(475, 460, 0);
            if (isPlayerTurn == true)
            {
                c3L2Red.SetActive(true);
                c3L2.transform.gameObject.tag = "Red";
                c3L2.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c3L2Yellow.SetActive(true);
                c3L2.transform.gameObject.tag = "Yellow";
                c3L2.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c3L2.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C3L2 = true;
            }
        }
        if (WinnerOfRoundText == "C3L3 gagne")
        {
            puissance4Case3.transform.position = new Vector3(475, 620, 0);
            if (isPlayerTurn == true)
            {
                c3L3Red.SetActive(true);
                c3L3.transform.gameObject.tag = "Red";
                c3L3.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c3L3Yellow.SetActive(true);
                c3L3.transform.gameObject.tag = "Yellow";
                c3L3.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c3L3.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C3L3 = true;
            }
        }
        if (WinnerOfRoundText == "C3L4 gagne")
        {
            puissance4Case3.transform.position = new Vector3(475, 780, 0);
            if (isPlayerTurn == true)
            {
                c3L4Red.SetActive(true);
                c3L4.transform.gameObject.tag = "Red";
                c3L4.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c3L4Yellow.SetActive(true);
                c3L4.transform.gameObject.tag = "Yellow";
                c3L4.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c3L4.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C3L4 = true;
            }
        }
        if (WinnerOfRoundText == "C3L5 gagne")
        {
            puissance4Case3.transform.position = new Vector3(475, 940, 0);
            if (isPlayerTurn == true)
            {
                c3L5Red.SetActive(true);
                c3L5.transform.gameObject.tag = "Red";
                c3L5.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c3L5Yellow.SetActive(true);
                c3L5.transform.gameObject.tag = "Yellow";
                c3L5.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c3L5.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C3L5 = true;
            }
        }
        if (WinnerOfRoundText == "C3L6 gagne")
        {
            Destroy(puissance4Case3);
            if (isPlayerTurn == true)
            {
                c3L6Red.SetActive(true);
                c3L6.transform.gameObject.tag = "Red";
                c3L6.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c3L6Yellow.SetActive(true);
                c3L6.transform.gameObject.tag = "Yellow";
                c3L6.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c3L6.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C3L6 = true;
            }
        }

        if (WinnerOfRoundText == "C4L1 gagne")
        {
            puissance4Case4.transform.position = new Vector3(640, 300, 0);
            if (isPlayerTurn == true)
            {
                c4L1Red.SetActive(true);
                c4L1.transform.gameObject.tag = "Red";
                c4L1.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c4L1Yellow.SetActive(true);
                c4L1.transform.gameObject.tag = "Yellow";
                c4L1.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c4L1.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C4L1 = true;
            }
        }
        if (WinnerOfRoundText == "C4L2 gagne")
        {
            puissance4Case4.transform.position = new Vector3(640, 460, 0);
            if (isPlayerTurn == true)
            {
                c4L2Red.SetActive(true);
                c4L2.transform.gameObject.tag = "Red";
                c4L2.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c4L2Yellow.SetActive(true);
                c4L2.transform.gameObject.tag = "Yellow";
                c4L2.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c4L2.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C4L2 = true;
            }
        }
        if (WinnerOfRoundText == "C4L3 gagne")
        {
            puissance4Case4.transform.position = new Vector3(640, 620, 0);
            if (isPlayerTurn == true)
            {
                c4L3Red.SetActive(true);
                c4L3.transform.gameObject.tag = "Red";
                c4L3.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c4L3Yellow.SetActive(true);
                c4L3.transform.gameObject.tag = "Yellow";
                c4L3.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            c4L3.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C4L3 = true;
            }
        }
        if (WinnerOfRoundText == "C4L4 gagne")
        {
            puissance4Case4.transform.position = new Vector3(640, 780, 0);
            if (isPlayerTurn == true)
            {
                c4L4Red.SetActive(true);
                c4L4.transform.gameObject.tag = "Red";
                c4L4.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c4L4Yellow.SetActive(true);
                c4L4.transform.gameObject.tag = "Yellow";
                c4L4.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c4L4.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C4L4 = true;
            }
        }
        if (WinnerOfRoundText == "C4L5 gagne")
        {
            puissance4Case4.transform.position = new Vector3(640, 940, 0);
            if (isPlayerTurn == true)
            {
                c4L5Red.SetActive(true);
                c4L5.transform.gameObject.tag = "Red";
                c4L5.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c4L5Yellow.SetActive(true);
                c4L5.transform.gameObject.tag = "Yellow";
                c4L5.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c4L5.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C4L5 = true;
            }
        }
        if (WinnerOfRoundText == "C4L6 gagne")
        {
            Destroy(puissance4Case4);
            if (isPlayerTurn == true)
            {
                c4L6Red.SetActive(true);
                c4L6.transform.gameObject.tag = "Red";
                c4L6.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c4L6Yellow.SetActive(true);
                c4L6.transform.gameObject.tag = "Yellow";
                c4L6.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c4L6.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C4L6 = true;
            }
        }

        if (WinnerOfRoundText == "C5L1 gagne")
        {
            puissance4Case5.transform.position = new Vector3(807.5f, 300, 0);
            if (isPlayerTurn == true)
            {
                c5L1Red.SetActive(true);
                c5L1.transform.gameObject.tag = "Red";
                c5L1.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c5L1Yellow.SetActive(true);
                c5L1.transform.gameObject.tag = "Yellow";
                c5L1.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c5L1.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C5L1 = true;
            }
        }
        if (WinnerOfRoundText == "C5L2 gagne")
        {
            puissance4Case5.transform.position = new Vector3(807.5f, 460, 0);
            if (isPlayerTurn == true)
            {
                c5L2Red.SetActive(true);
                c5L2.transform.gameObject.tag = "Red";
                c5L2.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c5L2Yellow.SetActive(true);
                c5L2.transform.gameObject.tag = "Yellow";
                c5L2.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            c5L2.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C5L2 = true;
            }
        }
        if (WinnerOfRoundText == "C5L3 gagne")
        {
            puissance4Case5.transform.position = new Vector3(807.5f, 620, 0);
            if (isPlayerTurn == true)
            {
                c5L3Red.SetActive(true);
                c5L3.transform.gameObject.tag = "Red";
                c5L3.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c5L3Yellow.SetActive(true);
                c5L3.transform.gameObject.tag = "Yellow";
                c5L3.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c5L3.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C5L3 = true;
            }
        }
        if (WinnerOfRoundText == "C5L4 gagne")
        {
            puissance4Case5.transform.position = new Vector3(807.5f, 780, 0);
            if (isPlayerTurn == true)
            {
                c5L4Red.SetActive(true);
                c5L4.transform.gameObject.tag = "Red";
                c5L4.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c5L4Yellow.SetActive(true);
                c5L4.transform.gameObject.tag = "Yellow";
                c5L4.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c5L4.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C5L4 = true;
            }
        }
        if (WinnerOfRoundText == "C5L5 gagne")
        {
            puissance4Case5.transform.position = new Vector3(807.5f, 940, 0);
            if (isPlayerTurn == true)
            {
                c5L5Red.SetActive(true);
                c5L5.transform.gameObject.tag = "Red";
                c5L5.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c5L5Yellow.SetActive(true);
                c5L5.transform.gameObject.tag = "Yellow";
                c5L5.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c5L5.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C5L5 = true;
            }
        }
        if (WinnerOfRoundText == "C5L6 gagne")
        {
            Destroy(puissance4Case5);
            if (isPlayerTurn == true)
            {
                c5L6Red.SetActive(true);
                c5L6.transform.gameObject.tag = "Red";
                c5L6.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c5L6Yellow.SetActive(true);
                c5L6.transform.gameObject.tag = "Yellow";
                c5L6.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c5L6.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C5L6 = true;
            }
        }

        if (WinnerOfRoundText == "C6L1 gagne")
        {
            puissance4Case6.transform.position = new Vector3(972.5f, 300, 0);
            if (isPlayerTurn == true)
            {
                c6L1Red.SetActive(true);
                c6L1.transform.gameObject.tag = "Red";
                c6L1.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c6L1Yellow.SetActive(true);
                c6L1.transform.gameObject.tag = "Yellow";
                c6L1.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c6L1.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C6L1 = true;
            }
        }
        if (WinnerOfRoundText == "C6L2 gagne")
        {
            puissance4Case6.transform.position = new Vector3(972.5f, 460, 0);
            if (isPlayerTurn == true)
            {
                c6L2Red.SetActive(true);
                c6L2.transform.gameObject.tag = "Red";
                c6L2.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c6L2Yellow.SetActive(true);
                c6L2.transform.gameObject.tag = "Yellow";
                c6L2.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c6L2.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C6L2 = true;
            }
        }
        if (WinnerOfRoundText == "C6L3 gagne")
        {
            puissance4Case6.transform.position = new Vector3(972.5f, 620, 0);
            if (isPlayerTurn == true)
            {
                c6L3Red.SetActive(true);
                c6L3.transform.gameObject.tag = "Red";
                c6L3.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c6L3Yellow.SetActive(true);
                c6L3.transform.gameObject.tag = "Yellow";
                c6L3.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c6L3.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C6L3 = true;
            }
        }
        if (WinnerOfRoundText == "C6L4 gagne")
        {
            puissance4Case6.transform.position = new Vector3(972.5f, 780, 0);
            if (isPlayerTurn == true)
            {
                c6L4Red.SetActive(true);
                c6L4.transform.gameObject.tag = "Red";
                c6L4.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c6L4Yellow.SetActive(true);
                c6L4.transform.gameObject.tag = "Yellow";
                c6L4.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c6L4.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C6L4 = true;
            }
        }
        if (WinnerOfRoundText == "C6L5 gagne")
        {
            puissance4Case6.transform.position = new Vector3(972.5f, 940, 0);
            if (isPlayerTurn == true)
            {
                c6L5Red.SetActive(true);
                c6L5.transform.gameObject.tag = "Red";
                c6L5.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c6L5Yellow.SetActive(true);
                c6L5.transform.gameObject.tag = "Yellow";
                c6L5.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c6L5.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C6L5 = true;
            }
        }
        if (WinnerOfRoundText == "C6L6 gagne")
        {
            c6L6Red.SetActive(true);
            Destroy(puissance4Case6);
            c6L6.transform.gameObject.tag = "Red";
            c6L6.gameObject.GetComponent<Renderer>().material.color = red;
            c6L6.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C6L6 = true;
            }
        }

        if (WinnerOfRoundText == "C7L1 gagne")
        {
            puissance4Case7.transform.position = new Vector3(1140, 300, 0);
            if (isPlayerTurn == true)
            {
                c7L1Red.SetActive(true);
                c7L1.transform.gameObject.tag = "Red";
                c7L1.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c7L1Yellow.SetActive(true);
                c7L1.transform.gameObject.tag = "Yellow";
                c7L1.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c7L1.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C7L1 = true;
            }
        }
        if (WinnerOfRoundText == "C7L2 gagne")
        {
            puissance4Case7.transform.position = new Vector3(1140, 460, 0);
            if (isPlayerTurn == true)
            {
                c7L2Red.SetActive(true);
                c7L2.transform.gameObject.tag = "Red";
                c7L2.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c7L2Yellow.SetActive(true);
                c7L2.transform.gameObject.tag = "Yellow";
                c7L2.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c7L2.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C7L2 = true;
            }
        }
        if (WinnerOfRoundText == "C7L3 gagne")
        {
            puissance4Case7.transform.position = new Vector3(1140, 620f, 0);
            if (isPlayerTurn == true)
            {
                c7L3Red.SetActive(true);
                c7L3.transform.gameObject.tag = "Red";
                c7L3.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c7L3Yellow.SetActive(true);
                c7L3.transform.gameObject.tag = "Yellow";
                c7L3.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c7L3.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C7L3 = true;
            }
        }
        if (WinnerOfRoundText == "C7L4 gagne")
        {
            puissance4Case7.transform.position = new Vector3(1140, 780, 0);
            if (isPlayerTurn == true)
            {
                c7L4Red.SetActive(true);
                c7L4.transform.gameObject.tag = "Red";
                c7L4.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c7L4Yellow.SetActive(true);
                c7L4.transform.gameObject.tag = "Yellow";
                c7L4.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c7L4.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C7L4 = true;
            }
        }
        if (WinnerOfRoundText == "C7L5 gagne")
        {
            puissance4Case7.transform.position = new Vector3(1140, 940, 0);
            if (isPlayerTurn == true)
            {
                c7L5Red.SetActive(true);
                c7L5.transform.gameObject.tag = "Red";
                c7L5.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c7L5Yellow.SetActive(true);
                c7L5.transform.gameObject.tag = "Yellow";
                c7L5.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c7L5.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C7L5 = true;
            }
        }
        if (WinnerOfRoundText == "C7L6 gagne")
        {
            Destroy(puissance4Case7);
            if (isPlayerTurn == true)
            {
                c7L6Red.SetActive(true);
                c7L6.transform.gameObject.tag = "Red";
                c7L6.gameObject.GetComponent<Renderer>().material.color = red;
            }
            else if (isPlayerTurn == false)
            {
                c7L6Yellow.SetActive(true);
                c7L6.transform.gameObject.tag = "Yellow";
                c7L6.gameObject.GetComponent<Renderer>().material.color = yellow;
            }
            
            c7L6.gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (startCountdown == false)
            {
                C7L6 = true;
            }
        }

        if (WinnerOfRoundText == null || WinnerOfRoundText == "")
        {
            new WaitForSeconds(0.01f);
            isPlayerTurn = false;
        }
    }
    private void Connect()
    {
        twitchClient = new TcpClient("irc.chat.twitch.tv", 6667);
        reader = new StreamReader(twitchClient.GetStream());
        writer = new StreamWriter(twitchClient.GetStream());

        writer.WriteLine("PASS " + password);
        writer.WriteLine("NICK " + username);
        writer.WriteLine("USER " + username + " 8 * :" + username);
        writer.WriteLine("JOIN #" + channelName);
        writer.Flush();
    }
    private void ReadChat()
    {
        if (twitchClient.Available > 0)
        {
            var message = reader.ReadLine(); //Read in the current message
            if (message.Contains("PRIVMSG"))
            {
                //Get the users name by splitting it from the string
                var splitPoint = message.IndexOf("!", 1);
                var chatName = message.Substring(0, splitPoint);
                chatName = chatName.Substring(1);


                if (!usersList.Contains(chatName))
                {
                    usersList.Add(chatName);
                }

                //Get the users message by splitting it from the string
                splitPoint = message.IndexOf(":", 1);
                message = message.Substring(splitPoint + 1);

                Puissance4(chatName, message);
                WinnerOfRound();
            }
        }
    }
    private void Puissance4(string username, string ChatInputs)
    {
        if (ChatInputs == "!1" && !Case1List.Contains(username) && !Case2List.Contains(username) && !Case3List.Contains(username) && !Case4List.Contains(username) && !Case5List.Contains(username) && !Case6List.Contains(username) && !Case7List.Contains(username))
        {
            Case1List.Add(username);
            howManyVote++;
        }
        if (ChatInputs == "!2" && !Case1List.Contains(username) && !Case2List.Contains(username) && !Case3List.Contains(username) && !Case4List.Contains(username) && !Case5List.Contains(username) && !Case6List.Contains(username) && !Case7List.Contains(username))
        {
            Case2List.Add(username);
            howManyVote++;
        }
        if (ChatInputs == "!3" && !Case1List.Contains(username) && !Case2List.Contains(username) && !Case3List.Contains(username) && !Case4List.Contains(username) && !Case5List.Contains(username) && !Case6List.Contains(username) && !Case7List.Contains(username))
        {
            Case3List.Add(username);
            howManyVote++;
        }
        if (ChatInputs == "!4" && !Case1List.Contains(username) && !Case2List.Contains(username) && !Case3List.Contains(username) && !Case4List.Contains(username) && !Case5List.Contains(username) && !Case6List.Contains(username) && !Case7List.Contains(username))
        {
            Case4List.Add(username);
            howManyVote++;
        }
        if (ChatInputs == "!5" && !Case1List.Contains(username) && !Case2List.Contains(username) && !Case3List.Contains(username) && !Case4List.Contains(username) && !Case5List.Contains(username) && !Case6List.Contains(username) && !Case7List.Contains(username))
        {
            Case5List.Add(username);
            howManyVote++;
        }
        if (ChatInputs == "!6" && !Case1List.Contains(username) && !Case2List.Contains(username) && !Case3List.Contains(username) && !Case4List.Contains(username) && !Case5List.Contains(username) && !Case6List.Contains(username) && !Case7List.Contains(username))
        {
            Case6List.Add(username);
            howManyVote++;
        }
        if (ChatInputs == "!7" && !Case1List.Contains(username) && !Case2List.Contains(username) && !Case3List.Contains(username) && !Case4List.Contains(username) && !Case5List.Contains(username) && !Case6List.Contains(username) && !Case7List.Contains(username))
        {
            Case7List.Add(username);
            howManyVote++;
        }
        Puissance4Prob();

    }
    private void Puissance4Prob()
    {
        if (howManyVote > 0)
        {
            if (Case1List.Count > 0)
            {
                puissance4Case1.text = Mathf.Round((Case1List.Count / howManyVote) * 100).ToString() + "%";
            }
            else if (Case1List.Count == 0)
            {
                puissance4Case1.text = "0%";
            }
            if (Case2List.Count > 0)
            {
                puissance4Case2.text = Mathf.Round((Case2List.Count / howManyVote) * 100).ToString() + "%";
            }
            else if (Case2List.Count == 0)
            {
                puissance4Case2.text = "0%";
            }
            if (Case3List.Count > 0)
            {
                puissance4Case3.text = Mathf.Round((Case3List.Count / howManyVote) * 100).ToString() + "%";
            }
            else if (Case3List.Count == 0)
            {
                puissance4Case3.text = "0%";
            }
            if (Case4List.Count > 0)
            {
                puissance4Case4.text = Mathf.Round((Case4List.Count / howManyVote) * 100).ToString() + "%";
            }
            else if (Case4List.Count == 0)
            {
                puissance4Case4.text = "0%";
            }
            if (Case5List.Count > 0)
            {
                puissance4Case5.text = Mathf.Round((Case5List.Count / howManyVote) * 100).ToString() + "%";
            }
            else if (Case5List.Count == 0)
            {
                puissance4Case5.text = "0%";
            }
            if (Case6List.Count > 0)
            {
                puissance4Case6.text = Mathf.Round((Case6List.Count / howManyVote) * 100).ToString() + "%";
            }
            else if (Case6List.Count == 0)
            {
                puissance4Case6.text = "0%";
            }
            if (Case7List.Count > 0)
            {
                puissance4Case7.text = Mathf.Round((Case7List.Count / howManyVote) * 100).ToString() + "%";
            }
            else if (Case7List.Count == 0)
            {
                puissance4Case7.text = "0%";
            }
        }

        if (howManyVote == 0)
        {
            WinnerOfRoundText = "";
            WinnerOfPuissance4Case.text = "0";
        }
    }
    private void WinnerOfRound()
    {
        if (Case1List.Count / howManyVote > Case2List.Count / howManyVote && Case1List.Count / howManyVote > Case3List.Count / howManyVote && Case1List.Count / howManyVote > Case4List.Count / howManyVote && Case1List.Count / howManyVote > Case5List.Count / howManyVote && Case1List.Count / howManyVote > Case6List.Count / howManyVote && Case1List.Count / howManyVote > Case7List.Count / howManyVote)
        {
            if (C1L1 == false && C1L2 == false && C1L3 == false && C1L4 == false && C1L5 == false && C1L6 == false)
            {
                WinnerOfRoundText = "C1L1 gagne";
                WinnerOfPuissance4Case.text = "C1";
            }
            if (C1L1 == true && C1L2 == false && C1L3 == false && C1L4 == false && C1L5 == false && C1L6 == false)
            {
                WinnerOfRoundText = "C1L2 gagne";
                WinnerOfPuissance4Case.text = "C1";
            }
            if (C1L1 == true && C1L2 == true && C1L3 == false && C1L4 == false && C1L5 == false && C1L6 == false)
            {
                WinnerOfRoundText = "C1L3 gagne";
                WinnerOfPuissance4Case.text = "C1";
            }
            if (C1L1 == true && C1L2 == true && C1L3 == true && C1L4 == false && C1L5 == false && C1L6 == false)
            {
                WinnerOfRoundText = "C1L4 gagne";
                WinnerOfPuissance4Case.text = "C1";
            }
            if (C1L1 == true && C1L2 == true && C1L3 == true && C1L4 == true && C1L5 == false && C1L6 == false)
            {
                WinnerOfRoundText = "C1L5 gagne";
                WinnerOfPuissance4Case.text = "C1";
            }
            if (C1L1 == true && C1L2 == true && C1L3 == true && C1L4 == true && C1L5 == true && C1L6 == false)
            {
                WinnerOfRoundText = "C1L6 gagne";
                WinnerOfPuissance4Case.text = "C1";
            }

        }
        if (Case2List.Count / howManyVote > Case1List.Count / howManyVote && Case2List.Count / howManyVote > Case3List.Count / howManyVote && Case2List.Count / howManyVote > Case4List.Count / howManyVote && Case2List.Count / howManyVote > Case5List.Count / howManyVote && Case2List.Count / howManyVote > Case6List.Count / howManyVote && Case2List.Count / howManyVote > Case7List.Count / howManyVote)
        {
            if (C2L1 == false && C2L2 == false && C2L3 == false && C2L4 == false && C2L5 == false && C2L6 == false)
            {
                WinnerOfRoundText = "C2L1 gagne";
                WinnerOfPuissance4Case.text = "C2";
            }
            if (C2L1 == true && C2L2 == false && C2L3 == false && C2L4 == false && C2L5 == false && C2L6 == false)
            {
                WinnerOfRoundText = "C2L2 gagne";
                WinnerOfPuissance4Case.text = "C2";
            }
            if (C2L1 == true && C2L2 == true && C2L3 == false && C2L4 == false && C2L5 == false && C2L6 == false)
            {
                WinnerOfRoundText = "C2L3 gagne";
                WinnerOfPuissance4Case.text = "C2";
            }
            if (C2L1 == true && C2L2 == true && C2L3 == true && C2L4 == false && C2L5 == false && C2L6 == false)
            {
                WinnerOfRoundText = "C2L4 gagne";
                WinnerOfPuissance4Case.text = "C2";
            }
            if (C2L1 == true && C2L2 == true && C2L3 == true && C2L4 == true && C2L5 == false && C2L6 == false)
            {
                WinnerOfRoundText = "C2L5 gagne";
                WinnerOfPuissance4Case.text = "C2";
            }
            if (C2L1 == true && C2L2 == true && C2L3 == true && C2L4 == true && C2L5 == true && C2L6 == false)
            {
                WinnerOfRoundText = "C2L6 gagne";
                WinnerOfPuissance4Case.text = "C2";
            }
        }
        if (Case3List.Count / howManyVote > Case1List.Count / howManyVote && Case3List.Count / howManyVote > Case2List.Count / howManyVote && Case3List.Count / howManyVote > Case4List.Count / howManyVote && Case3List.Count / howManyVote > Case5List.Count / howManyVote && Case3List.Count / howManyVote > Case6List.Count / howManyVote && Case3List.Count / howManyVote > Case7List.Count / howManyVote)
        {
            if (C3L1 == false && C3L2 == false && C3L3 == false && C3L4 == false && C3L5 == false && C3L6 == false)
            {
                WinnerOfRoundText = "C3L1 gagne";
                WinnerOfPuissance4Case.text = "C3";
            }
            if (C3L1 == true && C3L2 == false && C3L3 == false && C3L4 == false && C3L5 == false && C3L6 == false)
            {
                WinnerOfRoundText = "C3L2 gagne";
                WinnerOfPuissance4Case.text = "C3";
            }
            if (C3L1 == true && C3L2 == true && C3L3 == false && C3L4 == false && C3L5 == false && C3L6 == false)
            {
                WinnerOfRoundText = "C3L3 gagne";
                WinnerOfPuissance4Case.text = "C3";
            }
            if (C3L1 == true && C3L2 == true && C3L3 == true && C3L4 == false && C3L5 == false && C3L6 == false)
            {
                WinnerOfRoundText = "C3L4 gagne";
                WinnerOfPuissance4Case.text = "C3";
            }
            if (C3L1 == true && C3L2 == true && C3L3 == true && C3L4 == true && C3L5 == false && C3L6 == false)
            {
                WinnerOfRoundText = "C3L5 gagne";
                WinnerOfPuissance4Case.text = "C3";
            }
            if (C3L1 == true && C3L2 == true && C3L3 == true && C3L4 == true && C3L5 == true && C3L6 == false)
            {
                WinnerOfRoundText = "C3L6 gagne";
                WinnerOfPuissance4Case.text = "C3";
            }
        }
        if (Case4List.Count / howManyVote > Case1List.Count / howManyVote && Case4List.Count / howManyVote > Case2List.Count / howManyVote && Case4List.Count / howManyVote > Case3List.Count / howManyVote && Case4List.Count / howManyVote > Case5List.Count / howManyVote && Case4List.Count / howManyVote > Case6List.Count / howManyVote && Case4List.Count / howManyVote > Case7List.Count / howManyVote)
        {
            if (C4L1 == false && C4L2 == false && C4L3 == false && C4L4 == false && C4L5 == false && C4L6 == false)
            {
                WinnerOfRoundText = "C4L1 gagne";
                WinnerOfPuissance4Case.text = "C4";
            }
            if (C4L1 == true && C4L2 == false && C4L3 == false && C4L4 == false && C4L5 == false && C4L6 == false)
            {
                WinnerOfRoundText = "C4L2 gagne";
                WinnerOfPuissance4Case.text = "C4";
            }
            if (C4L1 == true && C4L2 == true && C4L3 == false && C4L4 == false && C4L5 == false && C4L6 == false)
            {
                WinnerOfRoundText = "C4L3 gagne";
                WinnerOfPuissance4Case.text = "C4";
            }
            if (C4L1 == true && C4L2 == true && C4L3 == true && C4L4 == false && C4L5 == false && C4L6 == false)
            {
                WinnerOfRoundText = "C4L4 gagne";
                WinnerOfPuissance4Case.text = "C4";
            }
            if (C4L1 == true && C4L2 == true && C4L3 == true && C4L4 == true && C4L5 == false && C4L6 == false)
            {
                WinnerOfRoundText = "C4L5 gagne";
                WinnerOfPuissance4Case.text = "C4";
            }
            if (C4L1 == true && C4L2 == true && C4L3 == true && C4L4 == true && C4L5 == true && C4L6 == false)
            {
                WinnerOfRoundText = "C4L6 gagne";
                WinnerOfPuissance4Case.text = "C4";
            }
        }
        if (Case5List.Count / howManyVote > Case1List.Count / howManyVote && Case5List.Count / howManyVote > Case2List.Count / howManyVote && Case5List.Count / howManyVote > Case3List.Count / howManyVote && Case5List.Count / howManyVote > Case4List.Count / howManyVote && Case5List.Count / howManyVote > Case6List.Count / howManyVote && Case5List.Count / howManyVote > Case7List.Count / howManyVote)
        {
            if (C5L1 == false && C5L2 == false && C5L3 == false && C5L4 == false && C5L5 == false && C5L6 == false)
            {
                WinnerOfRoundText = "C5L1 gagne";
                WinnerOfPuissance4Case.text = "C5";
            }
            if (C5L1 == true && C5L2 == false && C5L3 == false && C5L4 == false && C5L5 == false && C5L6 == false)
            {
                WinnerOfRoundText = "C5L2 gagne";
                WinnerOfPuissance4Case.text = "C5";
            }
            if (C5L1 == true && C5L2 == true && C5L3 == false && C5L4 == false && C5L5 == false && C5L6 == false)
            {
                WinnerOfRoundText = "C5L3 gagne";
                WinnerOfPuissance4Case.text = "C5";
            }
            if (C5L1 == true && C5L2 == true && C5L3 == true && C5L4 == false && C5L5 == false && C5L6 == false)
            {
                WinnerOfRoundText = "C5L4 gagne";
                WinnerOfPuissance4Case.text = "C5";
            }
            if (C5L1 == true && C5L2 == true && C5L3 == true && C5L4 == true && C5L5 == false && C5L6 == false)
            {
                WinnerOfRoundText = "C5L5 gagne";
                WinnerOfPuissance4Case.text = "C5";
            }
            if (C5L1 == true && C5L2 == true && C5L3 == true && C5L4 == true && C5L5 == true && C5L6 == false)
            {
                WinnerOfRoundText = "C5L6 gagne";
                WinnerOfPuissance4Case.text = "C5";
            }
        }
        if (Case6List.Count / howManyVote > Case1List.Count / howManyVote && Case6List.Count / howManyVote > Case2List.Count / howManyVote && Case6List.Count / howManyVote > Case3List.Count / howManyVote && Case6List.Count / howManyVote > Case4List.Count / howManyVote && Case6List.Count / howManyVote > Case5List.Count / howManyVote && Case6List.Count / howManyVote > Case7List.Count / howManyVote)
        {
            if (C6L1 == false && C6L2 == false && C6L3 == false && C6L4 == false && C6L5 == false && C6L6 == false)
            {
                WinnerOfRoundText = "C6L1 gagne";
                WinnerOfPuissance4Case.text = "C6";
            }
            if (C6L1 == true && C6L2 == false && C6L3 == false && C6L4 == false && C6L5 == false && C6L6 == false)
            {
                WinnerOfRoundText = "C6L2 gagne";
                WinnerOfPuissance4Case.text = "C6";
            }
            if (C6L1 == true && C6L2 == true && C6L3 == false && C6L4 == false && C6L5 == false && C6L6 == false)
            {
                WinnerOfRoundText = "C6L3 gagne";
                WinnerOfPuissance4Case.text = "C6";
            }
            if (C6L1 == true && C6L2 == true && C6L3 == true && C6L4 == false && C6L5 == false && C6L6 == false)
            {
                WinnerOfRoundText = "C6L4 gagne";
                WinnerOfPuissance4Case.text = "C6";
            }
            if (C6L1 == true && C6L2 == true && C6L3 == true && C6L4 == true && C6L5 == false && C6L6 == false)
            {
                WinnerOfRoundText = "C6L5 gagne";
                WinnerOfPuissance4Case.text = "C6";
            }
            if (C6L1 == true && C6L2 == true && C6L3 == true && C6L4 == true && C6L5 == true && C6L6 == false)
            {
                WinnerOfRoundText = "C6L6 gagne";
                WinnerOfPuissance4Case.text = "C6";
            }
        }
        if (Case7List.Count / howManyVote > Case1List.Count / howManyVote && Case7List.Count / howManyVote > Case2List.Count / howManyVote && Case7List.Count / howManyVote > Case3List.Count / howManyVote && Case7List.Count / howManyVote > Case4List.Count / howManyVote && Case7List.Count / howManyVote > Case5List.Count / howManyVote && Case7List.Count / howManyVote > Case6List.Count / howManyVote)
        {
            if (C7L1 == false && C7L2 == false && C7L3 == false && C7L4 == false && C7L5 == false && C7L6 == false)
            {
                WinnerOfRoundText = "C7L1 gagne";
                WinnerOfPuissance4Case.text = "C7";
            }
            if (C7L1 == true && C7L2 == false && C7L3 == false && C7L4 == false && C7L5 == false && C7L6 == false)
            {
                WinnerOfRoundText = "C7L2 gagne";
                WinnerOfPuissance4Case.text = "C7";
            }
            if (C7L1 == true && C7L2 == true && C7L3 == false && C7L4 == false && C7L5 == false && C7L6 == false)
            {
                WinnerOfRoundText = "C7L3 gagne";
                WinnerOfPuissance4Case.text = "C7";
            }
            if (C7L1 == true && C7L2 == true && C7L3 == true && C7L4 == false && C7L5 == false && C7L6 == false)
            {
                WinnerOfRoundText = "C7L4 gagne";
                WinnerOfPuissance4Case.text = "C7";
            }
            if (C7L1 == true && C7L2 == true && C7L3 == true && C7L4 == true && C7L5 == false && C7L6 == false)
            {
                WinnerOfRoundText = "C7L5 gagne";
                WinnerOfPuissance4Case.text = "C7";
            }
            if (C7L1 == true && C7L2 == true && C7L3 == true && C7L4 == true && C7L5 == true && C7L6 == false)
            {
                WinnerOfRoundText = "C7L6 gagne";
                WinnerOfPuissance4Case.text = "C7";
            }
        }

    }

    public void WinMessage()
    {
        if (IsWin.Winner == "Streamer")
        {
            GameEnd = true;
            WhoAreWinner.GetComponent<TextMeshProUGUI>().text  = username + " a gagné !";
            WinnerBack.SetActive(true);
            StreamerWin.SetActive(true);
        }
        if (IsWin.Winner == "Twitch Chat")
        {
            GameEnd = true;
            ChatWin.SetActive(true);
            WinnerBack.SetActive(false);
        }
    }
    public void ReadStringInput(string s)
    {

        print(s);
        if (s == "!1" || s == "!2" || s == "!3" || s == "!4" || s == "!5" || s == "!6" || s == "!7")
        {
            Puissance4(channelName, s);
            WinnerOfRound();
            CreateCoins();
            Case1List = new List<string> { };
            Case2List = new List<string> { };
            Case3List = new List<string> { };
            Case4List = new List<string> { };
            Case5List = new List<string> { };
            Case6List = new List<string> { };
            Case7List = new List<string> { };
            puissance4Case1.text = "!1";
            puissance4Case2.text = "!2";
            puissance4Case3.text = "!3";
            puissance4Case4.text = "!4";
            puissance4Case5.text = "!5";
            puissance4Case6.text = "!6";
            puissance4Case7.text = "!7";
            howManyVote = 0;
            WinnerOfPuissance4Case.text = "";
            isPlayerTurn = !isPlayerTurn;
            teste.text = "";
        }
    }
    public void StopRound()
    {
        timeToWait = 0;
    }
}
