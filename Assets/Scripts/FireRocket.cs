using UnityEngine;
using System.Collections;

public class FireRocket : MonoBehaviour {

    public GameObject rock;
    public GameObject rocket;


	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButtonDown("Fire" + gameObject.GetComponentInParent<playerCollision>().playerNumber.ToString()) && transform.childCount == 0)
        {
            rocket = (GameObject) Instantiate(rock, transform.position, transform.rotation);
            rocket.transform.parent = transform;

        }
        else if(Input.GetButtonDown("Fire" + gameObject.GetComponentInParent<playerCollision>().playerNumber.ToString()) && transform.childCount != 0)
        {
            gameObject.GetComponentInChildren<rocket>().triggeredExplosion();
        }
	}
}