using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour {

    public Transform cil1, cil2, cil3, cil4;
    public Transform finger1, finger2, obj;

	// Use this for initialization
	void Start ()
    {
        Vector3 midFingers = (finger1.position + finger2.position) * 0.5f;

        obj.position = new Vector3(midFingers.x, obj.position.y, midFingers.z);
        obj.right = finger2.position - finger1.position;

        configCil(cil1, finger1.position, finger2.position);
        configCil(cil2, finger1.position, obj.position);
        configCil(cil3, finger2.position, obj.position);
        configCil(cil4, midFingers, obj.position);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public static void configCil(Transform cil, Vector3 v1, Vector3 v2)
    {
        Vector3 v = (v1 - v2);
        cil.position = (v1 + v2) * 0.5f;
        cil.up = v;
        cil.localScale = new Vector3(cil.localScale.x, v.magnitude * 0.5f, cil.localScale.z);
    }
}
