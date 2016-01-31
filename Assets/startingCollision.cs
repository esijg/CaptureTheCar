using UnityEngine;
using System.Collections;

public class startingCollision : MonoBehaviour {


    public Vector3 startloc;
	// Use this for initialization
	void Start () {
        startloc = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        print(col.gameObject.tag == "player");
        if(col.gameObject.tag == "player")
        {
            col.gameObject.GetComponent<playerCollision>().timerOn = true;
            Destroy(gameObject);
        }
        else
        {
            col.gameObject.GetComponentInParent<playerCollision>().timerOn = true;
            Destroy(gameObject);
        }
    }
}
