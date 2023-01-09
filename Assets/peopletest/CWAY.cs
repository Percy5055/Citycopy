using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class CWAY : MonoBehaviour
{
    autocar controller; //把autocar當作控制器
    public Waypoint currentWaypoint;
    

    private void Awake()
    {
        controller = GetComponent<autocar>(); //使用autocar Coponent
    }
 
    void Start()
    {
        
        controller.SetDestination(currentWaypoint.GetPosition());
        

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
                
                    if(currentWaypoint.nextWaypoint != null)
                    {
                        currentWaypoint = currentWaypoint.nextWaypoint;
                    }
                    else
                    {
                        currentWaypoint = currentWaypoint.previousWaypoint;
                        
                    }
                    
                
              
            }
            controller.SetDestination(currentWaypoint.GetPosition());
        }
    }
}