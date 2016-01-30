using UnityEngine;
using System.Collections;

public class rocket : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        Vector3 expPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(expPos, 10);

        foreach (Collider hit in Physics.OverlapSphere(transform.position, 10))
        {

            if (hit.GetComponent<Rigidbody>())
            {
                hit.GetComponent<Rigidbody>().AddExplosionForce(10000, expPos, 10);
            }


        }
        Destroy(gameObject);



    }
}
