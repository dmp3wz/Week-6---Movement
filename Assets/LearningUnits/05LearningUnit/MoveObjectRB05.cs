using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectRB05 : MonoBehaviour
{
    Rigidbody rigidbody;
    Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        moveDirection = new Vector3(-2, 0,0); // Don't change this!
        rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(moveDirection, ForceMode.Force); // Don't change this!
        
    }
}
