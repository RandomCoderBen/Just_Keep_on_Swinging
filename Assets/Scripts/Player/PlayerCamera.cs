using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float mouseSensitivity = 150f;

    public Transform playerBody;

    float xRotation = 0f;

    public float PlayerSpeed;

    public ParticleSystem SpeedLines;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        SpeedLines.Stop();

        StartCoroutine(SpeedReader());

    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);



        if (PlayerSpeed >= 40)
        {
            
        }
        else
        {
            
        }



        if (PlayerSpeed >= 80)
        {
            SpeedLines.Play();
        }
        else
        {
            SpeedLines.Stop();
        }

    }



    IEnumerator SpeedReader()
    {
        bool isPlaying = true;

        while (isPlaying)
        {
            Vector3 prevPos = transform.position;

            yield return new WaitForFixedUpdate();

            PlayerSpeed = Mathf.RoundToInt(Vector3.Distance(transform.position, prevPos) / Time.fixedDeltaTime);
        }
    }

}
