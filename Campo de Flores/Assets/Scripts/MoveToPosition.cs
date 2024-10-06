using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPosition : MonoBehaviour
{
    public Transform target;
    // Update is called once per frame
    void Update()
    {
        //Move this object wherever the target object is positioned
        transform.position = target.position;
    }
}
