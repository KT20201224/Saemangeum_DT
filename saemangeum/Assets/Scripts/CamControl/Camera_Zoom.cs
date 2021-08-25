using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 카메라 시점 중심부로 고정 + 확대/축소 비율

public class Camera_Zoom : MonoBehaviour
{
    public Transform Center;

    Vector3 lookOffset = new Vector3(0, 50.0f, -50.0f);

    private float current_Zoom = 3.0f;
    private float min_Zoom = 1.0f;
    private float max_Zoom = 5.0f;
    public float zoom_speed = 1f;

    void Zoom(){
        current_Zoom -= Input.GetAxis("Mouse ScrollWheel") * zoom_speed;
        current_Zoom = Mathf.Clamp(current_Zoom, min_Zoom, max_Zoom);

        transform.localPosition = Center.localPosition + lookOffset * current_Zoom;
        transform.LookAt(Center);
    }

    void Update(){
        Zoom();
    }
}
