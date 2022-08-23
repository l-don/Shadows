using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Camera cam;
    private const float Distance = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform camT = cam.transform;
        //when pressing w move character forward
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += camT.forward * (Distance * Time.deltaTime);

        }
        //when pressing s move character backwards 
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -=camT.forward * (Distance * Time.deltaTime);
        }
        //when pressing a move character to the left
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= camT.right * (Distance * Time.deltaTime);
        }
        //when pressing d move character to the right
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += camT.right * (Distance * Time.deltaTime);
        }
    }
}