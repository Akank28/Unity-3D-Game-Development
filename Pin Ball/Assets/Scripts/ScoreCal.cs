using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCal : MonoBehaviour {

    // Use this for initialization
    public static int score;
    public int f = 0;
    public Text countText;
    public string abc = "";
    private 
	void Start () {
        score = 0;
        countText.text = "Score: " + score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        string str = collision.collider.GetType().ToString();
        if (collision.gameObject.name != "arrow" && collision.gameObject.name != "Player" && str.Contains("Sphere") && !abc.Contains(collision.gameObject.name)  )
        {
            score++;
           ScoreRem.count++;
            Debug.Log(ScoreRem.count.ToString());
            countText.text = "Score: " + score.ToString();
            abc = abc + collision.gameObject.name;
           // f = 1;
        }

        
    }
   
}
