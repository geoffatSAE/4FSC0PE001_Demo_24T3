using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using System.Linq;

public class SortMe : MonoBehaviour
{
    int[] arryOfNumbers = { 89, 32, 10, 3, 229, 29, 103, 1, 2, 3 };

    // Start is called before the first frame update
    void Start()
    {
        //output the original array
        string outputString = "";
        for(int i = 0; i < arryOfNumbers.Length; i++)
        {
            outputString = outputString + ", " + arryOfNumbers[i];
        }
        Debug.Log(outputString);

        //do the sort and overwrite the array
        arryOfNumbers = BubbleSortInts(arryOfNumbers);


        //output the sorted array
        outputString = "";
        for (int i = 0; i < arryOfNumbers.Length; i++)
        {
            outputString = outputString + ", " + arryOfNumbers[i];
        }
        Debug.Log(outputString);
    }
    

    // Update is called once per frame
    void Update()
    {


        
    }

    public int[] BubbleSortInts(int[] inputArray)
    {
        int n = inputArray.Length;
        for (int i = 0; i < n - 1; i++)
        {
            //create a loop through ALL the remaining items in the array
            for (int j = 0; j < n - i - 1; j++)
            {
                //compare the two objects
                if (inputArray[j] > inputArray[j + 1])
                {
                    //array first element is bigger, swap them
                    int firstBig = inputArray[j];
                    int secondSmall = inputArray[j + 1];

                    inputArray[j] = secondSmall; //asign the smaller to first
                    inputArray[j + 1] = firstBig; //asign th bigger to second
                }
            }

            

        }

  
        return inputArray;
    }
}
