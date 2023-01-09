using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public Waypoint previousWaypoint; //開頭的waypoint
    public Waypoint nextWaypoint; // 接著的waypoint

    [Range(0f, 5f)]
    public float width = 1f; //範圍的寬度

    public List<Waypoint> branches;

    [Range(0f, 1f)]
    public float branchRatio = 0.5f;


    public Vector3 GetPosition()
    {
        //兩者之間的距離
        Vector3 minBound = transform.position + transform.right * width / 2f;
        Vector3 maxBound = transform.position - transform.right * width / 2f;

        return Vector3.Lerp(minBound, maxBound, Random.Range(0f, 1f));

    }
}