using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMananger : MonoBehaviour
{
    [SerializeField] private string _gameSceneName = "MainGame";

    [SerializeField] private string _menuSceneName = "Menu";

    private string _thisSceneName;

    private void Awake()
    {
        _thisSceneName = SceneManager.GetActiveScene().name;
    }

    public void ToggleScene()
    {
        if (_thisSceneName == _menuSceneName)
        {
            SceneManager.LoadScene(_gameSceneName);
        }

        else

        if (_thisSceneName == _gameSceneName)
        {
            SceneManager.LoadScene(_menuSceneName);
        }

    }
}