using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float timer = 4.0f;
    public Vector3 directionOfTravel = Vector3.zero;
    public float speed = 2f;

    public enum EnemyState
    {
        Targeting, Moving, Attacking
    }
    public EnemyState enemyState;  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        switch (enemyState)
        {
            case EnemyState.Targeting:
                //start by targetting
                directionOfTravel = new Vector3(Random.Range(-1, 1), 0, Random.Range(-1, 1)); //maybe this is checking vision for Player?

                //transition to the moving
                enemyState = EnemyState.Moving; 

                break;


            case EnemyState.Moving:
                //move the enemy in the selected direction of the player! (or random so far)
                transform.Translate(directionOfTravel * Time.deltaTime * speed);


                //check if time is up, then move to next target
                if (timer < 0)
                {
                    timer = 4.0f;
                    enemyState = EnemyState.Targeting;
                }
                break;

            case EnemyState.Attacking:


                break;

        }

        /*
        if(timer < 0)
        { //timer has counted down
            timer = 4.0f; //reset timer

            


        } else
        {
            //timer -= Time.deltaTime;

        }
        */


        

    }
}
