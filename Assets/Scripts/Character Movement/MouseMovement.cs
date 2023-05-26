using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public enum RotationAxes
    {
        MouseXY = 0,
        MouseX = 1,
        MouseY = 2,
    }

    public RotationAxes axes = RotationAxes.MouseXY;
    
    public float verticalSens = 9.0f;
    public float horizontalSens = 9.0f;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;
    private float verticalRotation = 0;
    void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
        {
            body.freezeRotation = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (axes == RotationAxes.MouseX)
        {
           transform.Rotate(0,Input.GetAxis("Mouse X") * horizontalSens,0); 
        } else if (axes == RotationAxes.MouseY)
        {
            verticalRotation -= Input.GetAxis("Mouse Y") * verticalSens;
            verticalRotation = Mathf.Clamp(verticalRotation, minimumVert, maximumVert);

            float horizontalRotation = transform.localEulerAngles.y;

            transform.localEulerAngles = new Vector3(verticalRotation, horizontalRotation, 0);        }
        else
        {
            verticalRotation -= Input.GetAxis("Mouse Y") * verticalSens;
            verticalRotation = Mathf.Clamp(verticalRotation, minimumVert, maximumVert);

            float delta = Input.GetAxis("Mouse X") * horizontalSens;
            float horizontalRotation = transform.localEulerAngles.y + delta;
            
            transform.localEulerAngles = new Vector3(verticalRotation, horizontalRotation, 0);
        }
    }
}
