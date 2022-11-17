using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    void Start()
    {
        
    }
    
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        
        //movement relative to the players direction of view
        Vector3 move = transform.right * x + transform.forward * z;
        
        //use Char. controller to set movement
        //time.deltaTime makes it framerate independent
        controller.Move(move *speed * Time.deltaTime);
    }
}
//https://www.youtube.com/watch?v=_QajrabyTJc