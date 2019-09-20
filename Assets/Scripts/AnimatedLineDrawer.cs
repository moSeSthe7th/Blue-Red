using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedLineDrawer : MonoBehaviour
{
    LineRenderer lineRenderer;
    private float distance;
    private float counter;

    private Vector3 origin, destination;
    public float lineDrawSpeed = 4f;


    void Start()
    {

        lineRenderer = gameObject.GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
        origin = lineRenderer.GetPosition(0);
        destination = lineRenderer.GetPosition(1);
        lineRenderer.SetPosition(0, origin);

        distance = Vector3.Distance(origin, destination);

    }

    void Update()
    {

        if (counter < distance)
        {
            counter += .1f / lineDrawSpeed;
            float x = Mathf.Lerp(0, distance, counter);
            Vector3 point0 = origin;
            Vector3 point1 = destination;

            Vector3 pointALongLine = x * Vector3.Normalize(point1 - point0) + point0;

            lineRenderer.SetPosition(1, pointALongLine);
        }

    }
}
