using UnityEngine;
using System.Collections;

public class rocket : MonoBehaviour {

    public Transform explosionPrefab;

    // Use this for initialization
    void Start () {
        GameObject grandpa = transform.parent.parent.gameObject;
        Physics.IgnoreCollision(grandpa.GetComponent<Collider>(), GetComponent<Collider>());
        Destroy(gameObject, 3);
	}

    public void Explode(Vector3 pos, Quaternion rot)
    {
        Instantiate(explosionPrefab, pos, rot);
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision) {
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        Explode(pos, rot);
    }
}
