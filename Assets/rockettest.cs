using UnityEngine;
using System.Collections;

public class rockettest : MonoBehaviour {
    public GameObject cube;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(cube, transform.position, transform.rotation);
        }
	}
}
