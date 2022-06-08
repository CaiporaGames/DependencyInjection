using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupDI : MonoBehaviour
{
    [SerializeField] GameManagerDI gameManagerDI;
    [SerializeField] GameManagerDI02 gameManagerDI02;
    [SerializeField] UIManagerDI UIManagerDI;

    private void Awake()
    {
        UIManagerDI.Constructor(gameManagerDI);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            UIManagerDI.Constructor(gameManagerDI);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            UIManagerDI.Constructor(gameManagerDI02);
        }
    }
}
