using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchClick : MonoBehaviour {
    public float launchForce = 10000;
    public GameObject player;
    public Rigidbody rigidbody;
    public GameObject arrow;
    public GameObject pointer;


    // Use this for initialization
    void Start () {
      rigidbody = GetComponent<Rigidbody>();
      // rigidbody.AddForce(launchForce * transform.forward);
      player = GameObject.FindGameObjectWithTag("Player");
        arrow = GameObject.FindGameObjectWithTag("arrow");
        pointer = GameObject.FindGameObjectWithTag("pointer");

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        float mh = 1000;//Input.GetAxis("Horizontal");
        float mv = 1000;//Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(mh, 1000, mv);
        Vector3 dir = arrow.transform.position-player.transform.position;
  
        float a = Mathf.Sqrt((dir.x * dir.x) + (dir.y * dir.y) + (dir.z * dir.z));
        dir = dir / a;
        
       
        player.GetComponent<Rigidbody>().AddForce(launchForce*dir);
        player.GetComponent<Rigidbody>().AddTorque(movement);
        arrow.transform.position = new Vector3(10000f, 10000f, 10000f);
        pointer.active = false;


    }
}
