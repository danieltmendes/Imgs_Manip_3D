using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

    public Transform position1;
    public Transform position2;

	// Use this for initialization
	void Start () {
        transform.position = (position1.position + position2.position) * 0.5f;
        transform.rotation = Quaternion.LookRotation(position2.position - position1.position, Vector3.up);
        transform.localScale = new Vector3(4, 4, 4);// * Vector3.Distance(position2.position, position1.position);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Start();
        }

    }
}
