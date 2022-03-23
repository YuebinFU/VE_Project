using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Ubiq.Messaging;
using Ubiq.XR;
using UnityEngine;

public class opendoor_down : MonoBehaviour, INetworkComponent, INetworkObject {
    public NetworkId Id { get; set; }
    // NetworkId INetworkObject.Id => new NetworkId(1001);
    private NetworkContext context;

    void INetworkComponent.ProcessMessage (ReferenceCountedSceneGraphMessage message) {
        var msg = message.FromJson<Message> ();
        transform.position = msg.position;
        transform.rotation = msg.rotation;
    }
    // Start is called before the first frame update
    void Start () {
        context = NetworkScene.Register (this);

    }
    struct Message {
        public Vector3 position;
        public Quaternion rotation;
    }
    void OnCollisionEnter (Collision other) {
        gameObject.GetComponent<AudioSource> ().Play ();
        GameObject up_door = GameObject.Find ("Inner Environment/Doors/Trigger_Door_Down");
        up_door.transform.localEulerAngles = new Vector3 (0.0f, 80.303f, 0.0f);
    }
    void OnCollisionExit (Collision other) {
        gameObject.GetComponent<AudioSource> ().Play ();
        GameObject up_door = GameObject.Find ("Inner Environment/Doors/Trigger_Door_Down");
        up_door.transform.localEulerAngles = new Vector3 (0.0f, 30.303f, 0.0f);
    }
    // Update is called once per frame
    void Update () {
        Message message;
        message.position = transform.position;
        message.rotation = transform.rotation;
        context.SendJson (message);

    }
    public void Awake () {
        string newID = transform.position.ToString () + transform.rotation.ToString ();
        // string newID = System.DateTime.Now.ToFileTime().ToString();
        Id = new NetworkId ((uint) newID.GetHashCode ());
        Debug.Log (Id);
    }
}