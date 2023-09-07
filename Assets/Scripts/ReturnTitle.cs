using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ReturnTitle : MonoBehaviour
{
    
    private Image player1_img;
    private Image player2_img;

   public void OnClickChangeTitle()
    {
        Debug.Log("Test");
        
        player1_img = GameObject.Find("Player1").GetComponent<Image>();
        player2_img = GameObject.Find("Player2").GetComponent<Image>();

        Color color1 = player1_img.color;
        Color color2 = player2_img.color;
        color1.a = 0f;
        color2.a = 0f;

        player1_img.color = color1;
        player2_img.color = color2;
    }

    
}
