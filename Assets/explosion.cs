using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddExplosionForce(10000, transform.position, 100, 3.0f);
    }

    // Update is called once per frame
    void Update () {
        Destroy(gameObject, 4.0f);
    }
}
