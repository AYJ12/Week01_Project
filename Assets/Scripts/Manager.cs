using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public static string playerName;
    private GameObject obj;
    private Text playerName_text;
    public static int player_num;
    public GameObject player1;
    public GameObject player2;
    public Transform spawnPoint;

    public void Awake()
    {

        switch (player_num)
        {
            case 1:
                Instantiate(player1);
                player1.transform.position = spawnPoint.position;
                obj = GameObject.Find("PlayerName");
                playerName_text = obj.GetComponent<Text>();
                break;
            case 2:
                Instantiate(player2);
                player2.transform.position = spawnPoint.position;
                obj = GameObject.Find("PlayerName");
                playerName_text = obj.GetComponent<Text>();
                break;
        }
    }


    
    void Start()
    {
        ChangeName();
    }

    public void ChangeName()
    {
        playerName = playerName_text.text;
        playerName_text.text = InputNameCheck.playerName;
    }
}
