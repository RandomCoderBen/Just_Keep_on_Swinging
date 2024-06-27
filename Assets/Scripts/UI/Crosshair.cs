using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour
{

    public Transform Camera;


    public float SwingHookRange;
    public float PullHookRange;


    public Image SwingCrosshair;
    public Image PullCrosshair;

    public LayerMask GrapplePoint;

    [SerializeField] private Color OutofRange;
    [SerializeField] private Color InRange;


    //SpriteRenderer.color = new Color(1f, 1f, 1f, 1f);
    //SpriteRenderer.color = new Color(1f, 1f, 1f, 0.6f);



    void Start()
    {
        
    }

    
    void Update()
    {
        
        if (Physics.Raycast(Camera.position, Camera.forward, SwingHookRange, GrapplePoint))
        {
            SwingCrosshair.color = InRange;
        }
        else
        {
            SwingCrosshair.color = OutofRange;
        }



        
        if (Physics.Raycast(Camera.position, Camera.forward, PullHookRange, GrapplePoint))
        {
            PullCrosshair.color = InRange;
        }
        else
        {
            PullCrosshair.color = OutofRange;
        }


    }
}

