using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerDI : MonoBehaviour, IUIGameManagerDI
{
    [SerializeField] TextMeshProUGUI text;
    IGameManagerDI gameManager;

    private void Start()
    {
        text.text = "Subscribe to the channel, now!";
    }
    public void Constructor(IGameManagerDI gameManagerDI)
    {
        gameManager = gameManagerDI;
    }
    public void Change()
    {
        text.text = gameManager.GetValue();
    }

}
