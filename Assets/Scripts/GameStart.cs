using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameStart : MonoBehaviour
{
    public int CountdownTime  = 3;

    public TextMeshProUGUI CountdownDisplay;

    public GameObject Camera;

    public GameObject Player;
    public Rigidbody PlayerRB;


    // Start is called before the first frame update
    void Start()
    {

        Player.GetComponent<PlayerAirMovement>().enabled = false;
        Camera.GetComponent<PlayerCamera>().enabled = false;

        PlayerRB.useGravity = false;


        this.Wait(1f, () => { StartCoroutine(CountdownStart()); });
    }


    IEnumerator CountdownStart()
    {
        while (CountdownTime > 0)
        {
            CountdownDisplay.text = CountdownTime.ToString();

            yield return new WaitForSeconds(1f);

            CountdownTime--;
        }

        CountdownDisplay.text = "GO";

        this.Wait(0.5f, () => { CountdownDisplay.text = "";});


        Player.GetComponent<PlayerAirMovement>().enabled = true;

        PlayerRB.useGravity = true;

        Camera.GetComponent<PlayerCamera>().enabled = true;

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
