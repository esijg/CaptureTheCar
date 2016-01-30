using UnityEngine;
using System.Collections;

public class FireRocket : MonoBehaviour {

    public GameObject rock;


	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButtonDown("Fire" + gameObject.GetComponentInParent<playerCollision>().playerNumber.ToString()))
        {
            Instantiate(rock, transform.position, transform.rotation);

        }
	}
}