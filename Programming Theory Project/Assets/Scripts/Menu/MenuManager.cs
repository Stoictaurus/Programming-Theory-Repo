using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private InputField inputName;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager.Instance.ExitGame();
        }
    }

    public void StartGameAction()
    {
        GameManager.Instance.LoadSceneMain( inputName.text );
    }
}
