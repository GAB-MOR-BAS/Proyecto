using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyOrientation : MonoBehaviour
{
    public Transform target;
    // Update is called once per frame
    void Update()
    {
        transform.rotation = target.rotation;
    }
}
