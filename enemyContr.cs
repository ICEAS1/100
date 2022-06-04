using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyContr : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    float distance = 10f;
    public GameObject player;
    float distanceToPlayer;
    Vector3 enemyPosition;

    
    // Start is called before the first frame update
    void Start()
    {
        agent=GetComponent<UnityEngine.AI.NavMeshAgent>();
        enemyPosition=agent.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer=Vector3.Distance(player.transform.position,agent.transform.position);
        if(distanceToPlayer<=distance){
            agent.SetDestination(player.transform.position);
        }
        else{
            agent.SetDestination(enemyPosition);
        }
    }
}
