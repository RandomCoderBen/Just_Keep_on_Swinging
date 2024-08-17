using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidFloor : MonoBehaviour
{

    public Transform player, destination;

    public GameObject playerG;

    public Rigidbody PlayerRB;


    public PlayerCamera Cam;

    public SwingHook Swing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider c)
    {

        if (c.gameObject.name == "Player")  
        {
            Swing.StopSwing();

            playerG.SetActive(false);

            player.position = destination.position;

            playerG.SetActive(true);

            Cam.ResetReader();

            PlayerRB.velocity = Vector3.zero;

            Debug.Log("Player Detected");
        }
    }
}
