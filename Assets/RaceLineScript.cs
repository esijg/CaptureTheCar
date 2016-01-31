using UnityEngine;
using System.Collections;

public class RaceLineScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
 void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<RaceScript>().checkPointCounter >= 7)
        {
            col.gameObject.GetComponent<RaceScript>().lapCounter++;
            col.gameObject.GetComponent<RaceScript>().checkPointCounter = 0;
        }

    }
}
