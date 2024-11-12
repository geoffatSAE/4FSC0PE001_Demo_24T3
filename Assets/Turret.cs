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
    public float launchWait = 1.0f;

    public enum TurretSM
    {
        Following, Launching, Firing

    }
    public TurretSM turretSM;

    public GameObject bulletBillPrefab;
    public Transform spawnPointPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (turretSM)
        {
            case TurretSM.Following:
                Transform closestEnemytransform = enemyManager.ClosestEnemy().transform;
                transform.LookAt(closestEnemytransform.position);

                pointA = transform.position;
                pointB = closestEnemytransform.position;


                //count down launchWait time looking at the point
                launchWait -= Time.deltaTime;
                if (launchWait < 0)
                {
                    turretSM = TurretSM.Firing;
                    launchWait = 1;
                }
                break;

            case TurretSM.Launching:
                

                break;

            case TurretSM.Firing:

                //fire projectile
                Instantiate(bulletBillPrefab, spawnPointPosition.position, transform.rotation);


                turretSM = TurretSM.Following;

            break;

        }


    }


    void OnDrawGizmos()
    {
        // Set the Gizmos color
        Gizmos.color = lineColor;

        // Draw a line between pointA and pointB
        Gizmos.DrawLine(pointA, pointB);
    }
}
