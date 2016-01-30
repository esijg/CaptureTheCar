using UnityEngine;
using System.Collections;

public class startingCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        print("huzza");
        col.gameObject.GetComponent<playerCollision>().timerOn = true;
        Destroy(gameObject);
    }
}
