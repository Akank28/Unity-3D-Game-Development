using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowDrag : MonoBehaviour {

    private Vector3 screenPoint;
    private Vector3 offset;
    public GameObject pointer;
    public GameObject player;
    public GameObject arrow;

    private void Start()
    {
         arrow = GameObject.FindGameObjectWithTag("arrow");
        pointer = GameObject.FindGameObjectWithTag("pointer");
        player = GameObject.FindGameObjectWithTag("Player");

       
    }

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;
  /*      Vector3 dir = arrow.transform.position - player.transform.position;
        Vector3 point = pointer.transform.position;
        float a = Mathf.Sqrt((dir.x * dir.x) + (dir.y * dir.y) + (dir.z * dir.z));
        dir = dir / a;

        Vector3 planeNormal = new Vector3(0, 1, 0);
        Vector3 projectionA = Vector3.ProjectOnPlane(dir, planeNormal);
        Vector3 projectionB = Vector3.ProjectOnPlane(point, planeNormal);
        float angle = Vector3.SignedAngle(projectionA, projectionB,planeNormal);
        if (angle < 0)
        {
            angle = -(-179 - angle)+5;
        }
        else
            angle = -(179 - angle)-5;
        //  pointer.GetComponent<Rigidbody>().transform.rotation.z = angle;
         pointer.transform.rotation = Quaternion.Euler(76.798f, 3.015f, angle);
        Debug.Log("angle is:" + angle.ToString());*/
    }
}
