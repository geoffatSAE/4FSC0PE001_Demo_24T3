using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleStateExample : MonoBehaviour
{
    public enum ExampleState
    {
        Idle, Moving, Attacking
    }
    public ExampleState myExampleState;

    public float timer = 0;
    public bool enemyDetected;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        switch (myExampleState)
        {
            case ExampleState.Idle:
                Debug.Log("IS STATE A, idle");
                //do things here in A state, stand still?


                if (timer > 4.0f) myExampleState = ExampleState.Moving; //change to Moving after 4 seconds
                if (enemyDetected) myExampleState = ExampleState.Attacking; //seen the enemy, move to Attacking
                break;

            case ExampleState.Moving:
                  Debug.Log("is State B, Moving");
                  //do things here in B? move?
                 break;

            case ExampleState.Attacking:
                 Debug.Log("yep its Attacking now, pew pew pew!");
                 //do things here in C? attack?


                break;

        }


    }

}
