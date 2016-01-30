using UnityEngine;
using System.Collections;

public class newGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown("return"))
        {
            Application.LoadLevel("Main01");
        }
    }
}
