using UnityEngine;
using System.Collections;

public class RaceManager : MonoBehaviour {
    GameObject p1;
    GameObject p2;
    GameObject p3;
    GameObject p4;
    GUIStyle p1Col = new GUIStyle();
    GUIStyle p2Col = new GUIStyle();
    GUIStyle p3Col = new GUIStyle();
    GUIStyle p4Col = new GUIStyle();
    GameObject winner;
    // Use this for initialization
    void Start () {
        p1 = GameObject.Find("HotRod");
        p2 = GameObject.Find("Jeep");
        p3 = GameObject.Find("Racer");
        p4 = GameObject.Find("VWBraud");
        p1Col.normal.textColor = Color.blue;
        p2Col.normal.textColor = Color.green;
        p3Col.normal.textColor = Color.yellow;
        p4Col.normal.textColor = Color.red;
        p1Col.fontSize = 20;
        p2Col.fontSize = 20;
        p3Col.fontSize = 20;
        p4Col.fontSize = 20;
        winner = GameObject.Find("Winner");

    }
	
	// Update is called once per frame
	void Update () {

        if(p1.GetComponent<RaceScript>().lapCounter == 3)
        {
            winner.GetComponent<winnerScript>().winnerNr = 1;
            Object.DontDestroyOnLoad(winner);
            Application.LoadLevel("GameOver");
        }
        else if(p2.GetComponent<RaceScript>().lapCounter == 3)
        {
            winner.GetComponent<winnerScript>().winnerNr = 2;
            Object.DontDestroyOnLoad(winner);
            Application.LoadLevel("GameOver");
        }
        else if(p3.GetComponent<RaceScript>().lapCounter == 3)
        {
            winner.GetComponent<winnerScript>().winnerNr = 3;
            Object.DontDestroyOnLoad(winner);
            Application.LoadLevel("GameOver");
        }
        else if(p4.GetComponent<RaceScript>().lapCounter == 3)
        {
            winner.GetComponent<winnerScript>().winnerNr = 4;
            Object.DontDestroyOnLoad(winner);
            Application.LoadLevel("GameOver");
        }

	}



    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 150, 150), "P1 lap " + p1.GetComponent<RaceScript>().lapCounter.ToString() + "/3", p1Col);
        GUI.Label(new Rect(10, 30, 150, 150), "P2 lap " + p2.GetComponent<RaceScript>().lapCounter.ToString() + "/3", p2Col);
        GUI.Label(new Rect(10, 50, 150, 150), "P3 lap " + p3.GetComponent<RaceScript>().lapCounter.ToString() + "/3", p3Col);
        GUI.Label(new Rect(10, 70, 150, 150), "P4 lap " + p4.GetComponent<RaceScript>().lapCounter.ToString() + "/3", p4Col);
        GUI.Label(new Rect(600, 10, 150, 150), "P1 checkpoints: " + p1.GetComponent<RaceScript>().checkPointCounter.ToString() + "/7", p1Col);
        GUI.Label(new Rect(600, 30, 150, 150), "P2 checkpoints: " + p2.GetComponent<RaceScript>().checkPointCounter.ToString() + "/7", p2Col);
        GUI.Label(new Rect(600, 50, 150, 150), "P3 checkpoints: " + p3.GetComponent<RaceScript>().checkPointCounter.ToString() + "/7", p3Col);
        GUI.Label(new Rect(600, 70, 150, 150), "P4 checkpoints: " + p4.GetComponent<RaceScript>().checkPointCounter.ToString() + "/7", p4Col);
    }
}
