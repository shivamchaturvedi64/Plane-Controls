using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpinX : MonoBehaviour
{
    //private variables
    //here -20 determines the speed at which the propeller is rotating w.r.t z axis
    private Vector3 rotateChange = new(0, 0, -20);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //to rotate the propeller at one place
        transform.Rotate(rotateChange);
    }
}
