using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
   // public GameObject player;
    public Rigidbody rigidbody;
    public GameObject pointer;
    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
        pointer = GameObject.FindGameObjectWithTag("pointer");
    }
	
	// Update is called once per frame
	void Update () {
      /*  float h = Input.GetAxis("Horizontal") * 5;
        Vector3 vel = rigidbody.velocity;
        vel.x = h;*/
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 p = transform.position;
            p.x -= 0.1f;
            transform.position=  p;
            Vector3 pv = new Vector3(p.x+1f, -70.87f, -30.91f);
            pointer.transform.position = pv;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 p = transform.position;
            p.x += 0.1f;
            transform.position = p;
            Vector3 pv = new Vector3(p.x+1f, -70.87f, -30.91f);
            pointer.transform.position = pv;
        }
    }
}
