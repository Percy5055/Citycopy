using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterNavigationController : MonoBehaviour
{
    public float movementSpeed = 1;//移動速度
    public float rotationSpeed = 120; //旋轉速度
    public float stopDistance = 2f; //停止距離
    public Vector3 destination;
    public Animator animator;
    public bool reachedDestination;

    private Vector3 lastPosition;
    private Vector3 velocity;

    private void Awake()
    {
        movementSpeed = Random.Range(0.8f, 1f); //移動速度的random及範圍
        animator = GetComponent<Animator>();

    }


    void Update()
    {
        if (transform.position != destination)
        {
            Vector3 destinationDirection = destination - transform.position;
            destinationDirection.y = 0; 
            float destinationDistance = destinationDirection.magnitude; //目的地方向

            if (destinationDistance >= stopDistance)
            {
                reachedDestination = false; //到達目的地
                Quaternion targetRotation = Quaternion.LookRotation(destinationDirection);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
                transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
            }
            else
            {
                reachedDestination = true; 

            }

            //指定角色目的地

            velocity = (transform.position - lastPosition) / Time.deltaTime;
            velocity.y = 0;
            var velocityMagnitude = velocity.magnitude;
            velocity = velocity.normalized;
            var fwdDotProduct = Vector3.Dot(transform.forward, velocity);
            var rightDotProduct = Vector3.Dot(transform.right, velocity);

            animator.SetFloat("Horizontal", rightDotProduct);
            animator.SetFloat("Forward", fwdDotProduct);
        }

        lastPosition = transform.position;

    }



    public void SetDestination(Vector3 destination)
    {
        this.destination = destination;
        reachedDestination = false;
    }
}