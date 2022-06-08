using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerNoDI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] GameManagerNoDI gameManager;

    private void Start()
    {
        text.text = "Subscribe to the channel, now!";
    }
    public void Change()
    {
        text.text = gameManager.value;
    }    
}
