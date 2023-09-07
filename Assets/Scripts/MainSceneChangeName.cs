using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneChangeName : MonoBehaviour
{
    private string change_playerName;
    public InputField inputName;
    private Text nameText;

    public void Awake()
    {
        inputName = GameObject.Find("InputField").GetComponent<InputField>();
    }

    public void Update()
    {
        change_playerName = inputName.text;
    }

    public void MainPlayerNameChange()
    {
        if (change_playerName.Length >= 2 && change_playerName.Length <= 10)
        {
            InputNameCheck.playerName = change_playerName;
            nameText = GameObject.Find("PlayerName").GetComponent<Text>();
            nameText.text = change_playerName;
        }
    }
}
