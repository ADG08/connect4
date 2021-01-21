using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GoRecupPassword : MonoBehaviour
{
    private string channelName;
    private string password;

    public GameObject NoSave;
    public GameObject IsSave;
    public TMP_Text lastSaveText;
    public Data data;

    void Start()
    {
    }
    private void Update()
    {
        
        Puissance_4.username = channelName;
        Puissance_4.channelName = channelName;
        Puissance_4.password = password;
        Data.Username = channelName;
        Data.Password = password;
    }
    public void GetPassword()
    {
        Application.OpenURL("https://twitchapps.com/tmi/");
    }
    public void RecupChannelName(string cha)
    {
        channelName = cha;
    }
    public void RecupPassword(string pa)
    {
        password = pa ;
    }
    public void GoPlay()
    {
        if (channelName != null && password != null)
        {
            Application.LoadLevel(1);
        }
    }
    public void NoOneSave()
    {
        NoSave.SetActive(true);
        IsSave.SetActive(false);
    }

    public void OneSave(string SaveUsername, string SavePassword)
    {
        NoSave.SetActive(false);
        IsSave.SetActive(true);
        lastSaveText.text = "Êtes-vous " + SaveUsername + " ?";
        channelName = SaveUsername;
        password = SavePassword;
    }
    public void lastSaveIsUser()
    {
        GoPlay();
    }
    public void lastSaveIsNotUser()
    {
        NoSave.SetActive(true);
        IsSave.SetActive(false);
    }
    public void Save()
    {
        data.Save();
    }
}
