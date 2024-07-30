using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAirMovement : MonoBehaviour
{

    public Rigidbody PlayerRB;


    public float MoveSpeed = 11f;


    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;


    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MyInput();
        MovePlayer();
    }



    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        PlayerRB.AddForce(moveDirection.normalized * MoveSpeed * 0.3f, ForceMode.Force);
    }
}
