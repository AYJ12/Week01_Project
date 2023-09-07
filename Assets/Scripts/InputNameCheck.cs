using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputNameCheck : MonoBehaviour
{
    public static string playerName = null;

    public void OnClickLengthCheck()   //¾ÀÀüÈ¯
    {
        if (playerName.Length >= 2 && playerName.Length <= 10)
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
