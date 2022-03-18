using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Ubiq.XR;
using UnityEngine;

public class Diamond : MonoBehaviour, IGraspable
{
    private Hand grasped;

    void IGraspable.Grasp(Hand controller)
    {
        grasped = controller;
    }

    void IGraspable.Release(Hand controller)
    {
        grasped = null;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (grasped != null)
      {
          transform.position = grasped.transform.position;
          //transform.rotation = grasped.transform.rotation;
      }
    }
}
