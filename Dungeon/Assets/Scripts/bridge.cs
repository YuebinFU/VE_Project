using System.Collections;
using System.Collections.Generic;
using Ubiq.XR;
using UnityEngine;

public class bridge : MonoBehaviour, IGraspable
{
    public Hand grasped;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void IGraspable.Grasp(Hand controller)
    {
        Debug.Log("Clicked");
        grasped = controller;
    }
    void IGraspable.Release(Hand controller)
    {
        grasped = null;
    }
    // Update is called once per frame
    void Update()
    {
        if (grasped != null)
        {
            transform.position = grasped.transform.position;
            transform.rotation = grasped.transform.rotation;
        }
    }
}
