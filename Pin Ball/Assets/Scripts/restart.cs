using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restart : MonoBehaviour {
    public GameObject pointer;
    public GameObject player;
    public GameObject arrow;
    public Text gameend;
    public Text chances;
    public Text total;
   // public GameObject p1,p2,p3,p4,p5,p6,p7,p8,p9,p10;
   // Vector3 a, b, c, d1,d2,d3,d4,d5,d6,d7,d8,d9,d10;
    public int j = 0;
    public void Start()
    {
        // Debug.Log("in restart");
        /*    arrow = GameObject.FindGameObjectWithTag("arrow");
            pointer = GameObject.FindGameObjectWithTag("pointer");
            player = GameObject.FindGameObjectWithTag("Player");
            p1= GameObject.FindGameObjectWithTag("p1");
            p2 = GameObject.FindGameObjectWithTag("p2");
            p3 = GameObject.FindGameObjectWithTag("p3");
            p4 = GameObject.FindGameObjectWithTag("p4");
            p5 = GameObject.FindGameObjectWithTag("p5");
            p6 = GameObject.FindGameObjectWithTag("p6");
            p7 = GameObject.FindGameObjectWithTag("p7");
            p8 = GameObject.FindGameObjectWithTag("p8");
            p9 = GameObject.FindGameObjectWithTag("p9");
            p10 = GameObject.FindGameObjectWithTag("p10");

            a = arrow.transform.position;
            b = player.transform.position;
          //  b2 = player.transform.rotation;
            c = pointer.transform.position;
            d1 = p1.transform.position;
            d2 = p2.transform.position;
            d3 = p3.transform.position;
            d4 = p4.transform.position;
            d5 = p5.transform.position;
            d6 = p6.transform.position;
            d7 = p7.transform.position;
            d8 = p8.transform.position;
            d9 = p9.transform.position;
            d10 = p10.transform.position;
            */
        gameend.text = "";
        total.text = "";
        Imp.i++;
        j = 3 - Imp.i;
        chances.text = "Chances:" + j.ToString();
    //    Debug.Log(Imp.i.ToString());
    }

    // Use this for initialization
    public void reStart () {
        if (Imp.i < 3)
            SceneManager.LoadScene("SampleScene");
        else
        {
            gameend.text = "GAME ENDS";
            total.text = "Total_Score:" + ScoreRem.count.ToString();
        }
            
    /*    arrow.transform.position= a;
        player.transform.position= b;
        pointer.transform.position = c;
        player.active = true;
        p1.transform.position = d1;
        p2.transform.position=d2;
        p3.transform.position=d3;
        p4.transform.position=d4;
        p5.transform.position=d5;
        p6.transform.position=d6;
        p7.transform.position=d7;
        p8.transform.position=d8;
        p9.transform.position=d9;
        p10.transform.position=d10;
        pointer.active = true;*/

    }
	
	// Update is called once per frame
	
}
