using UnityEngine;
using System.Collections;

public class FireRocket : MonoBehaviour {

    public Rigidbody Rocket;
    public float RocketPower = 10f;


	// Use this for initialization
	void Start () {

    }

	// Update is called once per frame
	void Update () {
	    if(Input.GetButtonDown("Fire" + gameObject.GetComponentInParent<playerCollision>().playerNumber.ToString()) && transform.childCount == 0)
        {
            Rigidbody clone;
            clone = Instantiate(Rocket, transform.position, transform.rotation) as Rigidbody;
            clone.transform.parent = transform;
            clone.velocity = transform.TransformDirection(Vector3.forward * RocketPower);
        }
        else if(Input.GetButtonDown("Fire" + gameObject.GetComponentInParent<playerCollision>().playerNumber.ToString()) && transform.childCount != 0)
        {
            Vector3 pos = GetComponentInChildren<rocket>().transform.position;
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, transform.forward);
            gameObject.GetComponentInChildren<rocket>().Explode(pos, rot);
        }
	}
}
