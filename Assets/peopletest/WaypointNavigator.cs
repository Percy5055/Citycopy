using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class WaypointNavigator : MonoBehaviour
{
    CharacterNavigationController controller; //把CharacterNavigationController當作控制器
    public Waypoint currentWaypoint;
    int direction;

    private void Awake()
    {
        controller = GetComponent<CharacterNavigationController>(); //使用CharacterNavigationController Coponent
    }
 
    void Start()
    {
        
        controller.SetDestination(currentWaypoint.GetPosition());
        direction = Mathf.RoundToInt(UnityEngine.Random.Range(0f, 1f));

    }


    void Update()
    {
        if(controller.reachedDestination)
        {
            bool shouldBranch = false;

            if(currentWaypoint.branches != null && currentWaypoint.branches.Count > 0)
            {
                shouldBranch = Random.Range(0f,1f) <= currentWaypoint.branchRatio ? true : false;
            }

            if(shouldBranch)
            {
                currentWaypoint = currentWaypoint.branches[Random.Range(0, currentWaypoint.branches.Count - 1)];
            }
            else
            {
                if(direction == 0)
                {
                    if(currentWaypoint.nextWaypoint != null)
                    {
                        currentWaypoint = currentWaypoint.nextWaypoint;
                    }
                    else
                    {
                        currentWaypoint = currentWaypoint.previousWaypoint;
                        direction = 1;
                    }
                    
                }
                else if(direction == 1)
                {
                    if(currentWaypoint.previousWaypoint != null)
                    {
                        currentWaypoint = currentWaypoint.previousWaypoint;
                    }
                    else
                    {
                        currentWaypoint = currentWaypoint.nextWaypoint;
                        direction = 0;
                    }
                }
            }
            controller.SetDestination(currentWaypoint.GetPosition());
        }
    }
}