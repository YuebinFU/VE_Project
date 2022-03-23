﻿using System.Collections;
using System.Collections.Generic;
using Ubiq.XR;
using UnityEngine;

public class FourButtonDown : MonoBehaviour, IUseable
{
    public int isClicked = 200;
    public void Use(Hand controller)
    {
        GameObject player = GameObject.Find("Player");
        string currentPassword = player.GetComponent<StartDoorOpen>().password;
        player.GetComponent<StartDoorOpen>().password = currentPassword + "4";
    }

    public void UnUse(Hand controller)
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isClicked > 0)
        {
            //light up a few second
            isClicked--;
        }
    }
}