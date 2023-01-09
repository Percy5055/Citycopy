using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
        public Transform target;

    public float distanceUp = 15f;
    public float distanceAway = 10f;
    public float smooth = 2f;//位置平滑移動值
    public float camDepthSmooth = 5f;

    
    void LateUpdate()
    {
        //相機的位置
        Vector3 disPos = target.position + Vector3.up * distanceUp - target.forward * distanceAway;
        transform.position = Vector3.Lerp(transform.position, disPos  , Time.deltaTime * smooth);
        //相機的角度
        transform.LookAt(target.position);
    }
}
