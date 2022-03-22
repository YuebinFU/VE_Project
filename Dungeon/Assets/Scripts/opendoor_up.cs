using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor_up : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnCollisionEnter(Collision other)
    {
        gameObject.GetComponent<AudioSource>().Play();
        GameObject up_door = GameObject.Find("Inner Environment/Doors/Trigger_Door_Up");
        up_door.transform.localEulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
    }
    void OnCollisionExit(Collision other)
    {
        gameObject.GetComponent<AudioSource>().Play();
        GameObject up_door = GameObject.Find("Inner Environment/Doors/Trigger_Door_Up");
        up_door.transform.localEulerAngles = new Vector3(0.0f, 116.45f, 0.0f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
