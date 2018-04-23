using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {

    public Transform finger1, finger2, obj;
    public Transform cil1, cil2;

    public float moveDown = 0;
    public Transform leftHand;

	// Use this for initialization
	void Start ()
    {
        if(moveDown != 0)
        {
            leftHand.position -= (new Vector3(leftHand.right.x, 0, leftHand.right.z)).normalized * moveDown;
            obj.position -= new Vector3(0, moveDown, 0);
        }

        obj.position = new Vector3(finger1.position.x, obj.position.y, finger1.position.z);

        Triangle.configCil(cil1, finger1.position, obj.position);
        Triangle.configCil(cil2, finger1.position, finger2.position);
    }
	
	// Update is called once per frame
	void Update () {
	
        	
	}
}
