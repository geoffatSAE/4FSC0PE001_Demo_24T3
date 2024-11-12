using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Turret : MonoBehaviour
{
    public EnemyManager enemyManager;

    public Vector3 pointA;
    public Vector3 pointB;
    public Color lineColor = Color.red;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform closestEnemytransform = enemyManager.ClosestEnemy().transform;
        transform.LookAt(closestEnemytransform.position);

        pointA = transform.position;
        pointB = closestEnemytransform.position;
    }


    void OnDrawGizmos()
    {
        // Set the Gizmos color
        Gizmos.color = lineColor;

        // Draw a line between pointA and pointB
        Gizmos.DrawLine(pointA, pointB);
    }
}
