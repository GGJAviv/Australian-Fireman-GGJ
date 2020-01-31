using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private MenuMananger _menuMananger;

    private void Update()
    {
        if (Input.GetButton("Cancel"))
        {
            _menuMananger.ToggleScene();
        }
    }

}
