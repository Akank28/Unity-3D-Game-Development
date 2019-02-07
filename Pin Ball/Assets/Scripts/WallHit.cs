using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WallHit : MonoBehaviour {
    private Scene scene;
    public int chance = 3;
    public GameObject player;
    // Use this for initialization
    void Start () {
        scene = SceneManager.GetActiveScene();
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
   
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name=="wall" || collision.gameObject.name == "wall3" || collision.gameObject.name == "wall2" || collision.gameObject.name == "wall1"  )
        {
            //ExecuteAfterTime(1000);
            // for (int i = 0; i < 1000; i++) ;
            //  chance--;
            // Application.LoadLevel(scene.name);
            Vector3 v = player.GetComponent<Rigidbody>().transform.position;
            player.GetComponent<Rigidbody>().velocity = Vector3.zero;
           // player.GetComponent<Rigidbody>().freezeRotation = true;
            player.GetComponent<Rigidbody>().transform.position = v;
            player.active = false;
         // player.GetComponent<Rigidbody>.A

        }
    }
}
