using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{

    public int points = 0;
    
    protected Level1Stats StatTracker;

    

    // Start is called before the first frame update
    void Start()
    {
        StatTracker = GameObject.Find("Game Manager").GetComponent<Level1Stats>();  
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
            Debug.Log("Coin Collected");

            this.StatTracker.UpdateScore(1);
            //this.gameObject.SetActive(false);

            Destroy(gameObject);
        }
        

    }
}
