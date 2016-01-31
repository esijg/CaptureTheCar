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
    int p1counter;
    int p2counter;
    int p3counter;
    int p4counter;

    GUIStyle p1Col = new GUIStyle();
    GUIStyle p2Col = new GUIStyle();
    GUIStyle p3Col = new GUIStyle();
    GUIStyle p4Col = new GUIStyle();

    // blár grænn gulur rauður
    // Use this for initialization
    void Start () {
        p1 = GameObject.Find("HotRod");
        p2 = GameObject.Find("Jeep");
        p3 = GameObject.Find("Racer");
        p4 = GameObject.Find("VWBraud");
        p1timer = p1.GetComponent<playerCollision>().timer;
        p2timer = p2.GetComponent<playerCollision>().timer;
        p3timer = p3.GetComponent<playerCollision>().timer;
        p4timer = p4.GetComponent<playerCollision>().timer;
        winner = GameObject.Find("Winner");
        p1Col.normal.textColor = Color.blue;
        p2Col.normal.textColor = Color.green;
        p3Col.normal.textColor = Color.yellow;
        p4Col.normal.textColor = Color.red;
        p1Col.fontSize = 20;
        p2Col.fontSize = 20;
        p3Col.fontSize = 20;
        p4Col.fontSize = 20;
        p1counter = 0;
        p2counter = 0;
        p3counter = 0;
        p4counter = 0;
    }
	
	// Update is called once per frame
	void Update () {


        p1timer = p1.GetComponent<playerCollision>().timer;
        p2timer = p2.GetComponent<playerCollision>().timer;
        p3timer = p3.GetComponent<playerCollision>().timer;
        p4timer = p4.GetComponent<playerCollision>().timer;
        
        if(p1timer <= 0)
        {
            if (p1counter == 1)
            {
                winner.GetComponent<winnerScript>().winnerNr = 1;
                Object.DontDestroyOnLoad(winner);
                Application.LoadLevel("GameOver");
            }
            else
            {
                p1counter++;
                p1.GetComponent<playerCollision>().restartTimer();
                // p1.GetComponent<playerCollision>().reset();



            }

            
        }
        else if(p2timer <= 0)
        {
            if(p2counter == 1)
            {
                winner.GetComponent<winnerScript>().winnerNr = 2;
                Object.DontDestroyOnLoad(winner);
                Application.LoadLevel("GameOver");
            }
            else
            {
                p2counter++;
                p2.GetComponent<playerCollision>().restartTimer();
            }

            
        }
        else if(p3timer <= 0)
        {
            if(p3counter == 1)
            {
                winner.GetComponent<winnerScript>().winnerNr = 3;
                Object.DontDestroyOnLoad(winner);
                Application.LoadLevel("GameOver");
            }
            else
            {
                p3counter++;
                p3.GetComponent<playerCollision>().restartTimer();
            }

            
        }
        else if(p4timer <= 0)
        {
            if (p4counter == 1)
            {
                winner.GetComponent<winnerScript>().winnerNr = 4;
                Object.DontDestroyOnLoad(winner);
                Application.LoadLevel("GameOver");
            }
            else
            {
                p4counter++;
                p4.GetComponent<playerCollision>().restartTimer();
            }

            
        }
    }


    void OnGUI()
    {
       GUI.Label(new Rect(10, 10, 150, 150), "P1 time left: " + p1timer.ToString(), p1Col);
       GUI.Label(new Rect(10, 30, 150, 150), "P2 time left: " + p2timer.ToString(), p2Col);
       GUI.Label(new Rect(10, 50, 150, 150), "P3 time left: " + p3timer.ToString(), p3Col);
       GUI.Label(new Rect(10, 70, 150, 150), "P4 time left: " + p4timer.ToString(), p4Col);
       GUI.Label(new Rect(600, 10, 150, 150), "P1 victories: " + p1counter.ToString() + "/2", p1Col);
       GUI.Label(new Rect(600, 30, 150, 150), "P2 victories: " + p2counter.ToString() + "/2", p2Col);
       GUI.Label(new Rect(600, 50, 150, 150), "P3 victories: " + p3counter.ToString() + "/2", p3Col);
       GUI.Label(new Rect(600, 70, 150, 150), "P4 victories: " + p4counter.ToString() + "/2", p4Col);
    }
}
