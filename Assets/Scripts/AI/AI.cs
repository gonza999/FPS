using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] destinations;
    public float distanceToFollowPath=2;
    private int i = 0;
    private GameObject player;
    [Header("---Follow Player---")]
    public bool followPlayer;

    private float distanceToPlayer;
    public float distanceToFollowPlayer=10;

    private void Start()
    {
        navMeshAgent.destination = destinations[i].position;
        player = FindObjectOfType<PlayerMovement>().gameObject;
    }

    private void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position,player.transform.position);
        if (distanceToPlayer<distanceToFollowPlayer && followPlayer)
        {
            FollowPlayer();
        }
        else
        {
            EnemyPath();
        }
    }

    public void EnemyPath()
    {
        navMeshAgent.destination = destinations[i].position;

        if (Vector3.Distance(transform.position,destinations[i].position)<=distanceToFollowPath)
        {
            if (i>=destinations.Length-1)
            {
                i = 0;
            }
            else
            {
                i++;
            }
        }
    }

    public void FollowPlayer()
    {
        navMeshAgent.destination=player.transform.position;
    }
}
