using UnityEngine;
using System.Collections;

public class CheckPointCollider : MonoBehaviour {

    public int count;
    public int lapCount;
	// Use this for initialization
	void Start () {
        count = -1;
        lapCount = -1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.GetComponent<RaceScript>().checkPointCounter != count || col.gameObject.GetComponent<RaceScript>().lapCounter != lapCount)
        {
            col.gameObject.GetComponent<RaceScript>().checkPointCounter++;
            count = col.gameObject.GetComponent<RaceScript>().checkPointCounter;
            lapCount = col.gameObject.GetComponent<RaceScript>().lapCounter;
        }


    }
}
