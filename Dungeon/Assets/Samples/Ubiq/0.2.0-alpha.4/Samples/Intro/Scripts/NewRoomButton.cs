using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ubiq.Rooms;

namespace Ubiq.Samples
{
    public class NewRoomButton : MonoBehaviour
    {
        public SocialMenu mainMenu;
        public Text nameText;
        public bool publish;

        // Expected to be called by a UI element
        public void NewRoom ()
        {
            mainMenu.roomClient.Join(
                name: nameText.text,
                publish: publish);
            
            GameObject player = GameObject.Find("Player");
            player.transform.position = new Vector3(1.208f, 91.5f, 35.82f);
            player.GetComponent<StartDoorOpen>().playerType = 1;
           // Debug.Log(StartDoorOpen.playerType);
            //player.transform.position = new Vector3(1.253f, 103.0f, 10.5f);
        }
    }
}
