using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class ThrowPlayer : MonoBehaviour
{

    public Rigidbody PlayerRB;

    private Vector3 PullPoint;

    public float LaunchSpeed = 90f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider c)
    {

        if (c.gameObject.name == "Player")
        {
            LaunchPlayer();
        }


    }



    private void LaunchPlayer()
    {

        PlayerRB.useGravity = false;

        PlayerRB.mass = 0.1f;

        PlayerRB.AddForce(transform.forward * LaunchSpeed, ForceMode.VelocityChange);

        this.Wait(1.5f, () => { StopLaunch(); });

    }


    private void StopLaunch()
    {
        PlayerRB.useGravity = true;

        PlayerRB.mass = 0.6f;
    }


}
