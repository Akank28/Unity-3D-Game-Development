using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour {
    public GameObject pointer;
    public GameObject player;
    public GameObject arrow;
    // Use this for initialization
    void Start () {
        arrow = GameObject.FindGameObjectWithTag("arrow");
        pointer = GameObject.FindGameObjectWithTag("pointer");
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update () {
       
        Vector3 p = new Vector3(player.transform.position.x+1f, -70.87f, -30.91f);
        pointer.transform.position = p;
        Vector3 dir = arrow.transform.position - player.transform.position;
        Vector3 point = pointer.transform.position;
        float a = Mathf.Sqrt((dir.x * dir.x) + (dir.y * dir.y) + (dir.z * dir.z));
        dir = dir / a;

        Vector3 planeNormal = new Vector3(0, 1, 0);
        Vector3 projectionA = Vector3.ProjectOnPlane(dir, planeNormal);
        Vector3 projectionB = Vector3.ProjectOnPlane(point, planeNormal);
        float angle = Vector3.SignedAngle(projectionA, projectionB, planeNormal);
        if (angle < 0)
        {
            angle = -(-179 - angle) + 10;
        }
        else
            angle = -(173 - angle) - 5;
        pointer.transform.rotation = Quaternion.Euler(76.798f, 3.015f, angle);
      //  Debug.Log("angle is:" + angle.ToString());
    }
}
