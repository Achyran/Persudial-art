using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuggListenter : MonoBehaviour
{
    public bool IsActive = true;
    private void Start()
    {
        EventManager.current.event_Init += debugInit;
        EventManager.current.event_ButtonPressed += debugButton;
    }

    private void debugInit()
    {
        Debug.Log("Debug: Init Was Called");
    }
    private void debugButton()
    {
        Debug.Log("Debug: Button Was Called");
    }
    private void OnDestroy()
    {
        EventManager.current.event_Init -= debugInit;
        EventManager.current.event_ButtonPressed -= debugButton;
    }
}
