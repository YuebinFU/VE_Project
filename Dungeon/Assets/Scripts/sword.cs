using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ubiq.XR;

public class sword : MonoBehaviour, IGraspable
{
    // Start is called before the first frame update
    public Hand grasped;
    void Start()
    {
        
    }

    void IGraspable.Grasp(Hand controller)
    {
        Debug.Log("Clicked sword");
        grasped = controller;
        GameObject player = GameObject.Find("Player");
        float dis = Vector3.Distance(player.transform.position, transform.position);
        Debug.Log("sword distance is " + dis);
        if (dis < 5.0)
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
