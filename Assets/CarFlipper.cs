using UnityEngine;
using System.Collections;

public class CarFlipper : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            transform.Translate(Vector3.up * 5, Space.World);
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
	}
}
