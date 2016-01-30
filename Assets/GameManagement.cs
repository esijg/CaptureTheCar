using UnityEngine;
using System.Collections;

public class GameManagement : MonoBehaviour {

    GameObject p1;
    GameObject p2;
    GameObject p3;
    GameObject p4;
    float p1timer;
    float p2timer;
    float p3timer;
    float p4timer;
    GameObject winner;

    // Use this for initialization
    void Start () {
        p1 = GameObject.Find("p1_Car");
        p2 = GameObject.Find("p2_Car");
        p3 = GameObject.Find("p3_Car");
        p4 = GameObject.Find("p4_Car");
        p1timer = p1.GetComponent<playerCollision>().timer;
        p2timer = p2.GetComponent<playerCollision>().timer;
        p3timer = p3.GetComponent<playerCollision>().timer;
        p4timer = p4.GetComponent<playerCollision>().timer;
        winner = GameObject.Find("Winner");

    }
	
	// Update is called once per frame
	void Update () {
        p1timer = p1.GetComponent<playerCollision>().timer;
        p2timer = p2.GetComponent<playerCollision>().timer;
        p3timer = p3.GetComponent<playerCollision>().timer;
        p4timer = p4.GetComponent<playerCollision>().timer;
        
        if(p1timer <= 0)
        {
            winner.GetComponent<winnerScript>().winnerNr = 1;
            Object.DontDestroyOnLoad(winner);
            Application.LoadLevel("GameOver");
            
        }
        else if(p2timer <= 0)
        {
            winner.GetComponent<winnerScript>().winnerNr = 2;
            Object.DontDestroyOnLoad(winner);
            Application.LoadLevel("GameOver");
            
        }
        else if(p3timer <= 0)
        {
            winner.GetComponent<winnerScript>().winnerNr = 3;
            Object.DontDestroyOnLoad(winner);
            Application.LoadLevel("GameOver");
            
        }
        else if(p4timer <= 0)
        {
            winner.GetComponent<winnerScript>().winnerNr = 4;
            Object.DontDestroyOnLoad(winner);
            Application.LoadLevel("GameOver");
            
        }
    }


    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 150, 150), "P1 time left: " + p1timer.ToString());
        GUI.Label(new Rect(10, 20, 150, 150), "P2 time left: " + p2timer.ToString());
        GUI.Label(new Rect(10, 30, 150, 150), "P3 time left: " + p3timer.ToString());
        GUI.Label(new Rect(10, 40, 150, 150), "P4 time left: " + p4timer.ToString());
    }
}
