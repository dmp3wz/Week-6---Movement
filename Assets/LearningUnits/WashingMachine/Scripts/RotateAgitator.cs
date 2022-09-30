using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAgitator : MonoBehaviour
{
    Vector3 moveDirection;
    Rigidbody rigidbody;
    //some code came from an online resource: https://docs.unity3d.com/ScriptReference/Rigidbody.MoveRotation.html#:~:text=Use%20Rigidbody.,in%20any%20intermediate%20frames%20rendered.
    

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        moveDirection = new Vector3(0,100,0);
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        Quaternion delta = Quaternion.Euler(moveDirection * Time.fixedDeltaTime);
        rigidbody.MoveRotation(rigidbody.rotation * delta);
    }
}
