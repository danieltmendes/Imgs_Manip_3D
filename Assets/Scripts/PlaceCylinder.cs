using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCylinder : MonoBehaviour {

    public Transform pointA, pointB;

	// Use this for initialization
	void Start ()
    {
        Triangle.configCil(this.transform, pointA.position, pointB.position);
	}
	
	// Update is called once per frame
	void Update ()
    {
        Triangle.configCil(this.transform, pointA.position, pointB.position);
    }
}
