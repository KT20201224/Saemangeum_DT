using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float horizontalAngle = 0.0f;
    private float verticalAngle = 0.0f;
    private float angularVelocity = 30.0f;

    void rotate(){
        var horizontalRotation = Input.GetAxis("Mouse X") * angularVelocity * Time.deltaTime;
        var verticalRotation = Input.GetAxis("Mouse Y") * angularVelocity * Time.deltaTime;

        horizontalAngle += horizontalRotation;
        verticalAngle += verticalRotation;
  
        transform.rotation = Quaternion.Euler(verticalAngle, horizontalAngle, 0f);
    }

    void Update(){
        rotate();
    }
    
}