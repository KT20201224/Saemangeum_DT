using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 카메라 회전 + WASD로 움직임

public class Move : MonoBehaviour
{
    private float move_X = 0.0f;
    private float move_Z = 0.0f;

    void wasd_Move(){

        if (Input.GetKey("w"))
        {
            move_Z += 60f * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            move_Z += -60f * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            move_X += -60f * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            move_X += 60f * Time.deltaTime;
        }

        transform.position = new Vector3(move_X, 0, move_Z);
    }

    void Update(){
        wasd_Move();
    }
}
