using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleSceneSelectButton2 : MonoBehaviour
{
    private GameObject player;
    private Image player_img;

    private void Awake()
    {
        player = GetComponent<GameObject>();
    }


    public void CheckPlayer2()
    {
        player_img = GameObject.Find("Player2").GetComponent<Image>();
        Color color = player_img.color;
        color.a = 255f;
        player_img.color = color;
        Manager.player_num = 2;
    }
}
