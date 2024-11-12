using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] ArrayOfEnemies;
    //public float[] distancesOfEnemies;
    public Transform turretTransform;

    // Start is called before the first frame update
    void Start()
    {
        //distancesOfEnemies = new float[3];

    }

    // Update is called once per frame
    void Update()
    {
        ArrayOfEnemies = SortEnemies(ArrayOfEnemies);


    }

    public GameObject ClosestEnemy()
    {


        return ArrayOfEnemies[0];
    }
    
    public GameObject[] SortEnemies(GameObject[] inputArray)
    {
        int n = inputArray.Length;
        for (int i = 0; i < n - 1; i++)
        {
            //create a loop through ALL the remaining items in the array
            for (int j = 0; j < n - i - 1; j++)
            {
                //compare the two objects
                //first calculate the two distances
                float distanceOfFirst = Vector3.Distance(turretTransform.position, inputArray[j].transform.position);
                float distanceOfSecond = Vector3.Distance(turretTransform.position,inputArray[j + 1].transform.position);
                
                //then compare them
                if (distanceOfFirst > distanceOfSecond)
                {
                    //array first element is bigger, swap them
                    GameObject firstBig = inputArray[j];
                    GameObject secondSmall = inputArray[j + 1];

                    inputArray[j] = secondSmall; //asign the smaller to first
                    inputArray[j + 1] = firstBig; //asign th bigger to second
                }
            }



        }


        return inputArray;
    }

}
