using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BBox : MonoBehaviour
{
    LineRenderer lrenderer;

    public void Start()
    {
        lrenderer = GetComponent<LineRenderer>();
        lrenderer.positionCount = 16;
    }

    public void Update()
    {
        BoxCollider collider = GetComponent<BoxCollider>();
        Vector3 min = transform.InverseTransformPoint(collider.bounds.min);
        Vector3 max = transform.InverseTransformPoint(collider.bounds.max);

        int i = 0;

        lrenderer.SetPosition(i++, transform.TransformPoint(new Vector3(min.x, min.y, min.z)));
        lrenderer.SetPosition(i++, transform.TransformPoint(new Vector3(max.x, min.y, min.z)));
        lrenderer.SetPosition(i++, transform.TransformPoint(new Vector3(max.x, min.y, max.z)));
        lrenderer.SetPosition(i++, transform.TransformPoint(new Vector3(min.x, min.y, max.z)));
        lrenderer.SetPosition(i++, transform.TransformPoint(new Vector3(min.x, min.y, min.z)));
        lrenderer.SetPosition(i++, transform.TransformPoint(new Vector3(min.x, max.y, min.z)));
        lrenderer.SetPosition(i++, transform.TransformPoint(new Vector3(max.x, max.y, min.z)));
        lrenderer.SetPosition(i++, transform.TransformPoint(new Vector3(max.x, max.y, max.z)));
        lrenderer.SetPosition(i++, transform.TransformPoint(new Vector3(min.x, max.y, max.z)));
        lrenderer.SetPosition(i++, transform.TransformPoint(new Vector3(min.x, max.y, min.z)));
        lrenderer.SetPosition(i++, transform.TransformPoint(new Vector3(min.x, max.y, max.z)));
        lrenderer.SetPosition(i++, transform.TransformPoint(new Vector3(min.x, min.y, max.z)));
        lrenderer.SetPosition(i++, transform.TransformPoint(new Vector3(max.x, min.y, max.z)));
        lrenderer.SetPosition(i++, transform.TransformPoint(new Vector3(max.x, max.y, max.z)));
        lrenderer.SetPosition(i++, transform.TransformPoint(new Vector3(max.x, max.y, min.z)));
        lrenderer.SetPosition(i++, transform.TransformPoint(new Vector3(max.x, min.y, min.z)));
    }

    /*void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(transform.position + center, size);
    }*/
}