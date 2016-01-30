using UnityEngine;
using System.Collections;

public class playerCollision : MonoBehaviour {

    public float timer;
    public bool timerOn;
    public int playerNumber;
    public GameObject indicator;
    public bool flag;
    float timeSinceImpact;
    GameObject ind;
    // Use this for initializat
    void Start () {
        timer = 100;
        timeSinceImpact = 100;
        print(timerOn);
        flag = false;

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
        if (timerOn == true && flag == false)
        {
            ind = (GameObject) Instantiate(indicator, transform.position, transform.rotation);
            ind.transform.parent = transform;
            flag = true;
            
        }
        if (timerOn == false && flag == true)
        {
            Destroy(ind);
            flag = false;
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
