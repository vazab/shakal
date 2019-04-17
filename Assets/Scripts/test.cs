using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{


    void Start()
    {
        //Create 2 random Arrays
        int[] array1 = new int[Random.Range(3, 11)];
        int[] array2 = new int[Random.Range(3, 11)];
        Debug.Log("===============Massive 1");
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = Random.Range(0, 100);
            Debug.Log(array1[i]);
        }
        Debug.Log("===============Massive 2");
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = Random.Range(0, 100);
            Debug.Log(array2[i]);
        }
        
        //Arrays merge
        int[] unsortMassive = new int[array1.Length + array2.Length];

        for (int i = 0; i < array1.Length; i++)
        {
            unsortMassive[i] = array1[i];
        }

        for (int i = array1.Length; i < unsortMassive.Length; i++)
        {
            unsortMassive[i] = array2[i - array1.Length];
        }

        //Sorting Array
        Debug.Log("==========SORT===========");

        for (int s = 0; s < unsortMassive.Length; s++)
        {
            for (int i = s+1; i < unsortMassive.Length; i++)
            {
                if (unsortMassive[s] > unsortMassive[i])
                {
                    int buffer = unsortMassive[s];
                    unsortMassive[s] = unsortMassive[i];
                    unsortMassive[i] = buffer;
                }
            }
            Debug.Log(unsortMassive[s]);
        }
    }

    void Update()
    {

    }
}
