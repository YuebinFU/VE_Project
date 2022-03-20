using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor_down : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        GameObject up_door = GameObject.Find("Inner Environment/Doors/Trigger_Door_Down");
        up_door.transform.localEulerAngles = new Vector3(0.0f, -70.0f, 0.0f);
    }
    void OnCollisionExit(Collision other)
    {
        GameObject up_door = GameObject.Find("Inner Environment/Doors/Trigger_Door_Down");
        up_door.transform.localEulerAngles = new Vector3(0.0f, 26.755f, 0.0f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
