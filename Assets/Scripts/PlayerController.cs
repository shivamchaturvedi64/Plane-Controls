using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float inputHorizontal;
    private float inputVertical;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //To get Inputs from Player
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");
        //Moving Vehicle Forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * inputVertical);
        //For the rotation of the Vehicle
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * inputHorizontal);
    }
}
