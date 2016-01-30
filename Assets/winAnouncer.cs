using UnityEngine;
using System.Collections;

public class winAnouncer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject win;
        win = GameObject.Find("Winner");
        string winnerNr = win.GetComponent<winnerScript>().winnerNr.ToString();
        this.GetComponent<TextMesh>().text = "Game Over \n Player " + winnerNr + " wins!\n Press \"Enter\" to reset.";

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
