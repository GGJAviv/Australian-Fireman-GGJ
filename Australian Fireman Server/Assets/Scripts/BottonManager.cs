using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BottonManager : MonoBehaviour
{

    [SerializeField] private Slider _soundVolumeSlider;

    [SerializeField] private MenuMananger _menuMananger;


    public void StartGame()
    {
        _menuMananger.ToggleScene();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChangeSoundVolume()
    {
        AudioListener.volume = _soundVolumeSlider.value;
    }

}
