using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultInputName : MonoBehaviour
{
    public InputField playerNameInput;

    private void Awake()
    {
        InputNameCheck.playerName = playerNameInput.GetComponent<InputField>().text;
    }

    // Update is called once per frame
    void Update()
    {
        InputNameCheck.playerName = playerNameInput.GetComponent<InputField>().text;
    }
}
