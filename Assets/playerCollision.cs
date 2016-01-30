using UnityEngine;
using System.Collections;

public class playerCollision : MonoBehaviour {

    float timer;
    public bool timerOn;
    public int playerNumber;
    float timeSinceImpact;
	// Use this for initializat
	void Start () {
        timer = 120;
        timeSinceImpact = 100;
        print(timerOn);
	}
	

	// Update is called once per frame
	void Update () {
        if (timeSinceImpact <= 2)
        {
            timeSinceImpact += Time.deltaTime;
        }
        if (timerOn == true)
        {
            timer -= Time.deltaTime;
        }

    }


    void OnCollisionEnter(Collision col)
    {
        if(timerOn == true && col.gameObject.tag == "Player" && timeSinceImpact > 2)
        {
            timerOn = false;
            timeSinceImpact = 0;
            col.gameObject.GetComponent<playerCollision>().timerOn = true;
            col.gameObject.GetComponent<playerCollision>().timeSinceImpact = 0;
            print("Player " + playerNumber + " has " + timer + " seconds left.");
        }
    }


}
