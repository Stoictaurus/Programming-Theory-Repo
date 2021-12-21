using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    [SerializeField] private Text playerName;
    [SerializeField] private Text hungerText;
    [SerializeField] private Text restText;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager.Instance.ExitToMenu();
        }
    }

    public void DisplayPlayerStatus(GameObject player)
    {
        var playerScript = player.GetComponent<Player>();
        if (playerScript != null)
        {
            playerName.text = playerScript.playerName;
            hungerText.text = "Hunger: " + playerScript.hunger;
            restText.text = "Rest   : " + playerScript.rest;
        }
        else
        {
            playerName.text = "---";
            hungerText.text = "Hunger: -";
            restText.text = "Rest   : -";
        }
    }
}
