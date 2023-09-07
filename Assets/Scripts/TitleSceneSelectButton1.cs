using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleSceneSelectButton1 : MonoBehaviour
{
    private GameObject player;
    private Image player_img;

    private void Awake()
    {
        player = GetComponent<GameObject>();
    }

    public void CheckPlayer1()
    {
        player_img = GameObject.Find("Player1").GetComponent<Image>();
        Color color = player_img.color;
        color.a = 255f;
        player_img.color = color;
        Manager.player_num = 1;
    }
}
