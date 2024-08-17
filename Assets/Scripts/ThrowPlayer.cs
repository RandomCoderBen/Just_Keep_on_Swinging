using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class ThrowPlayer : MonoBehaviour
{

    public Rigidbody PlayerRB;

    private Vector3 PullPoint;

    public float LaunchSpeed = 90f;

    public ParticleSystem BoostLines;


    public SwingHook Swing;

    [SerializeField]
    AudioSource ThrowAudio;


    // Start is called before the first frame update
    void Start()
    {
        BoostLines.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider c)
    {

        if (c.gameObject.name == "Player")
        {
            Swing.StopSwing();

            LaunchPlayer();

            ThrowAudio.Play();
        }


    }



    private void LaunchPlayer()
    {

        PlayerRB.useGravity = false;

        PlayerRB.mass = 0.2f;

        PlayerRB.angularDrag = 10f;

        PlayerRB.AddForce(transform.forward * LaunchSpeed, ForceMode.VelocityChange);

        this.Wait(1.5f, () => { StopLaunch(); });

    }


    private void StopLaunch()
    {
        PlayerRB.useGravity = true;

        PlayerRB.mass = 0.6f;

        PlayerRB.angularDrag = 0f;

    }


}
