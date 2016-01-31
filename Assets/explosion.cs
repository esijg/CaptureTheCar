using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {

    public float AreaOfEffect = 6.0f;
    public float Strength = 500;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddExplosionForce(10000, transform.position, Strength, AreaOfEffect);
    }

    // Update is called once per frame
    void Update () {
        Destroy(gameObject, 4.0f);
    }
}
