using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //when pressing w move character forward
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
        //when pressing s move character backwards 
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0, 0, -10);
        }
        //when pressing a move character to the left
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-10, 0, 0);
        }
        //when pressing d move character to the right
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(10, 0, 0);
        }
    }
}