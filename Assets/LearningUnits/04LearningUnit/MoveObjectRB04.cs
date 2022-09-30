using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectRB04 : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        moveDirection = new Vector3(-2400, 0,0); // Don't change this!
        rigidbody = GetComponent<Rigidbody>();


        // Don't move this line or add any new values (such as coefficients)!
        rigidbody.AddForce(moveDirection, ForceMode.Force);

        // I just want to give a nudge to the blue cube, but 
	    // stay on the white plane and not fall over the edge myself...
        rigidbody.AddForce(moveDirection, ForceMode.Impulse); //we want to add an instantaneous force that will push the blue block, so I used ForceMode.Impulse to do this, as it will apply this force without making the red cube fall off. 
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
