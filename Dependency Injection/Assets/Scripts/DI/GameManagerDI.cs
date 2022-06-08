using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerDI : MonoBehaviour, IGameManagerDI
{
    string value = "Please ;)";  

    public string GetValue()
    {
        return value;
    }  
}
