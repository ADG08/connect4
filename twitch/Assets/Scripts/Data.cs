using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Data : MonoBehaviour
{
    public static string Username;
    public static string Password;

    private string saveSeparator = "%VALUE%";

    private string key = "g8sgd2s38dg3ssd3";
    private string crypted = "";
    private string decrypted = "";

    public GoRecupPassword main;

    void Start()
    {
        string f = Application.dataPath + "/";
        Directory.CreateDirectory(f + "saves");
        if (!File.Exists(Application.dataPath + "/saves/data.json"))
        {
            main.NoOneSave();
        }
        else if (File.Exists(Application.dataPath + "/saves/data.json"))
        {
            Load();
            main.OneSave(Username, Password);
        }
    }
    string Encrypt(string data)
    {
        for (int i = 0; i < data.Length; i++)
        {
            crypted = crypted + (char)(data[i] ^ key[i % key.Length]);
        }
        return crypted;
    }
    string Decrypt(string data)
    {
        for (int i = 0; i < data.Length; i++)
        {
            decrypted = decrypted + (char)(data[i] ^ key[i % key.Length]);
        }
        return decrypted;
    }


    public void Save()
    {
        string[] content = new string[]
        {
            Username,
            Password
        };

        string saveStrings = string.Join(saveSeparator, content);
        crypted = Encrypt(saveStrings);
        File.WriteAllText(Application.dataPath + "/saves/data.json", crypted);
    }
    public void Load()
    {
        string saveString = File.ReadAllText(Application.dataPath + "/saves/data.json");
        decrypted = Decrypt(saveString);
        string[] content = decrypted.Split(new[] { saveSeparator }, System.StringSplitOptions.None);
        Username = content[0];
        Password = content[1];
    }
}
