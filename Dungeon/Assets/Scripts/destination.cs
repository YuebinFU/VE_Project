using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destination : MonoBehaviour
{
    public AudioSource victory;
    public Rigidbody Rigidbody_of_player;
    // Start is called before the first frame update
    void Start()
    {
        Hide();
    }

    void OnCollisionEnter(Collision other)
    {
        gameObject.GetComponent<AudioSource>().Play();
        Debug.Log(other.gameObject.name);
        Rigidbody_of_player = other.gameObject.GetComponent<Rigidbody>();
        Rigidbody_of_player.constraints = RigidbodyConstraints.FreezeAll;

    }
    void Show()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
    }

    void Hide()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
    }
}
