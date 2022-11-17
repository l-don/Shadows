using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform playerBody;

    private float xRotation = 0f;
    
    void Start()
    {
        //hide and lock Cursor to center of the screen (in theory, practically only hides it)
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float mouseX = Input.GetAxis(("Mouse X")) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis(("Mouse Y")) * mouseSensitivity * Time.deltaTime;
        
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        //Rotate with xRotation instead of Rotate to make clamp possible
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate((Vector3.up*mouseX));

        
        
    }
}
//https://www.youtube.com/watch?v=_QajrabyTJc