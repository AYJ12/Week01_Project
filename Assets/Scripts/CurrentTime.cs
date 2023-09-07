using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class CurrentTime : MonoBehaviour
{
    public TextMeshProUGUI tmp_GUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tmp_GUI.text = GetCurrentDate();
    }
    public static string GetCurrentDate()
    {
        return DateTime.Now.ToString(("HH:mm"));
    }
}
