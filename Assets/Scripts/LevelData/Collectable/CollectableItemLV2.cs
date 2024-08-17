using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItemLV2 : MonoBehaviour
{

    public int points = 0;
    
    protected Level2Stats StatTracker;

    [SerializeField]
    AudioSource PickupAudio;


    // Start is called before the first frame update
    void Start()
    {
        StatTracker = GameObject.Find("Game Manager").GetComponent<Level2Stats>();  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, 20f * Time.deltaTime, Space.Self);
    }

    private void OnTriggerEnter(Collider c)
    {

        if (c.gameObject.name == "Player")
        {
            PickupAudio.Play();

            Debug.Log("Coin Collected");

            this.StatTracker.UpdateScore(1);
            //this.gameObject.SetActive(false);

            

            Destroy(gameObject);
        }
        

    }
}
