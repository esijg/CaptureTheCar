using UnityEngine;
using System.Collections;

public class startingCollision : MonoBehaviour {

    GameObject ind;
    public GameObject indicator;
    public Vector3 startloc;
	// Use this for initialization
	void Start () {
        startloc = transform.position;
        ind = (GameObject)Instantiate(indicator, transform.position, transform.rotation);
	}

	// Update is called once per frame
	void Update () {

	}

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "player")
        {
            col.gameObject.GetComponent<playerCollision>().timerOn = true;
            Destroy(ind);
            Destroy(gameObject);
        }
        else
        {
            col.gameObject.GetComponentInParent<playerCollision>().timerOn = true;
            Destroy(ind);
            Destroy(gameObject);
        }
    }
}
