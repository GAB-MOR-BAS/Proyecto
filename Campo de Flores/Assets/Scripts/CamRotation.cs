using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotation : MonoBehaviour
{
    public float xSensitivity;
    public float ySensitivity;

    public Transform orientation;

    float xRotation;
    float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        //Keep the cursor locked in the middle of the screen and invisible
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        RotateCamera();
    }

    private void RotateCamera()
    {
        //Get the mouse's x and y input
        float xMouseInput = Input.GetAxisRaw("Mouse X") * xSensitivity;
        float yMouseInput = Input.GetAxisRaw("Mouse Y") * ySensitivity;
        xRotation -= yMouseInput;
        yRotation += xMouseInput;
        //Keep the camera from rotating more than 90º when looking up or down
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //Rotate the camera
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
