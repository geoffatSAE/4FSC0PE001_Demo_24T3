using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AITwo : MonoBehaviour
{
    public Transform[] navigationPoints;
    NavMeshAgent myNavmeshAgent;

    float movementTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        myNavmeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        movementTimer += Time.deltaTime;
        

        if (movementTimer >= 8.0f)
        {
            myNavmeshAgent.SetDestination(navigationPoints[Random.Range(0, 4)].position);

            movementTimer = 0.0f;
        }
        
    }
}
