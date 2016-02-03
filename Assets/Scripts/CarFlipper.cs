using UnityEngine;
using System.Collections;

public class CarFlipper : MonoBehaviour {

    float timer;
	// Use this for initialization
	void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Flip" + gameObject.GetComponentInParent<playerCollision>().playerNumber.ToString()) && timer < 0.1)
        {
            transform.Translate(Vector3.up * 5, Space.World);
            transform.localEulerAngles = new Vector3(0, 0, 0);
            timer = 5;
        }
        if(timer>=0)
        {
            timer = timer - Time.deltaTime;
        }
	}
}
