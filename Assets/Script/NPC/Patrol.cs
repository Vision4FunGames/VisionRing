using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public Transform[] waypoints;    // Array of waypoints for the NPC to follow
    public float movementSpeed = 2f; // Speed at which the NPC moves
    private int currentWaypointIndex; // Index of the current waypoint
    public Animator animator;        // Animator component for animation control
    public bool patroling = true;
    public NavMeshAgent navMeshAgent;
    public float waypointDistance = 0.5f;
    private bool patrolStart;
    void Start()
    {
        // animator.speed = movementSpeed; // Set animation speed to match movement speed
        currentWaypointIndex = 0;       // Start from the first waypoint
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    
    public void PatrolStop()
    {
        navMeshAgent.speed = 0;
    }
    
    public void PatrolResume()
    {
        navMeshAgent.speed = 5;
    }
    
    void Update()
    {
        if (patroling)
        {
            animator.SetFloat("runspeed", navMeshAgent.velocity.magnitude / navMeshAgent.speed * 2f);
            Move(waypoints[currentWaypointIndex]);
        }
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position) < waypointDistance)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }
    public void Move(Transform trans)
    {
        navMeshAgent.SetDestination(trans.position);
        RotateTowards(trans);
    }
    
    private void RotateTowards(Transform target)
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation =
            Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z)); // flattens the vector3
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 10);
    }
}
