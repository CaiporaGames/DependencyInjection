using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerDI02 : MonoBehaviour, IGameManagerDI
{
    string value = "Now, give a like to the video. Hehe";  

    public string GetValue()
    {
        return value;
    }  
}
