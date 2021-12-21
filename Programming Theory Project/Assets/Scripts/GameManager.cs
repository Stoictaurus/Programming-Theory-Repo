using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void LoadSceneMain()
    {
        SceneManager.LoadScene(1);
    }
    
    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}

public struct RoomBounds
{
    public float top;
    public float bottom;
    public float left;
    public float right;

    public bool PointInBounds(Vector3 point)
    {
        return point.x > left && point.x < right && point.z > bottom && point.z < top;
    }
}
