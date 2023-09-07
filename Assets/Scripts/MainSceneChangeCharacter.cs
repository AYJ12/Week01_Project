using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainSceneChangeCharacter : MonoBehaviour
{
    private string buttonName;
    public GameObject player1;
    public GameObject player2;
    public Transform spawnPoint;

    public void ChangeCharacter()
    {
        buttonName = EventSystem.current.currentSelectedGameObject.name;
        
        if(buttonName == "Player1_Image")
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            player1.GetComponent<Text>().text = Manager.playerName;
            Instantiate(player1);
            player1.transform.position = spawnPoint.position;
            
        }else if(buttonName == "Player2_Image")
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            player2.GetComponent<Text>().text = Manager.playerName;
            Instantiate(player2);
            player2.transform.position = spawnPoint.position;
        }
    }
}
