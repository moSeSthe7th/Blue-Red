using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OrthographicCameraScaler : MonoBehaviour
{
    public void SetCameraScale(float orthographicSize)
    {
        GetComponent<Camera>().orthographic = true;
        GetComponent<Camera>().orthographicSize = orthographicSize;
    }
}
