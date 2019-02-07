using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
    
	
	
	// Update is called once per frame
	public void UpdateScore (int count) {
        PlayerPrefs.SetInt("Score:", count);
	}
    public int getScore()
    {
        return PlayerPrefs.GetInt("Score:");
    }
}
