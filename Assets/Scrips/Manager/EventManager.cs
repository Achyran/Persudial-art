using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager current;

    private void Awake()
    {
        if(current == null)
        {
            current = this;
        }
        else
        {
            Debug.Log("Gamemaster Allerady exist, Destroying this!");
            Destroy(this);
        }
    }
    private void Start()
    {
        Init();
    }
    //----------------------------Events-----------------------------//
    public event Action event_Init;
    public event Action event_ButtonPressed;

    private void Init()
    {
        Debug.Log("Generator Initialised");
        if(event_Init != null)
        {
            event_Init();
        }
    }
    void Button()
    {
        Debug.Log("Button Is Pressed");
        if (event_ButtonPressed != null)
        {
            event_ButtonPressed();
        }
    }



}
