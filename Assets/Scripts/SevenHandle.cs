using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SevenHandle : MonoBehaviour {

    public Transform pointA, pointB;
    public bool Xpos;
    public bool secondLevel;

	// Use this for initialization
	void Start ()
    {
        if (secondLevel)
        {
            transform.position = (pointA.position + pointB.position) * 0.5f;
        }
        else
        {
            transform.position = pointA.position;
            transform.RotateAround(transform.parent.position, transform.parent.up, 360 / 3.0f * (Xpos ? 1.0f : -1.0f));
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (secondLevel)
        {
            transform.position = (pointA.position + pointB.position) * 0.5f;
        }
        else
        {
            transform.position = pointA.position;
            transform.RotateAround(transform.parent.position, transform.parent.up, 360 / 3.0f * (Xpos ? 1.0f : -1.0f));
        }
    }
}
