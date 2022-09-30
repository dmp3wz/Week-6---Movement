using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject01 : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        // My position equals my position PLUS 
	    // where I want to be by the end of this frame...
        transform.position = transform.position + moveDirection; //change this to add move direction instead of 0, as this keeps this cube stationary. 
    }
}
