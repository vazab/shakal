using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Optimize : MonoBehaviour
{
    // join
    void SortMerge(int[] mass1, int[] mass2, int[] res)
    {
        Array.Sort(mass1);
        Array.Sort(mass2);

        int count1 = mass1.Length;
        int count2 = mass2.Length;
        int a = 0, b = 0;
        int i = 0;

        while (a < count1 && b < count2)
        {
            if (mass1[a] <= mass2[b])
            {
                res[i++] = mass1[a++];
            }
            else
            {
                res[i++] = mass2[b++];
            }
        }
        if (a < count1)
        {
            for (int j = a; j < count1; j++)
            {
                res[i++] = mass1[j];
            }
        }
        else
        {
            for (int j = b; j < count2; j++)
            {
                res[i++] = mass2[j];
            }
        }
    }

    void Start()
    {
        //Create 2 random Arrays
        int[] array1 = new int[UnityEngine.Random.Range(3, 11)];
        int[] array2 = new int[UnityEngine.Random.Range(3, 11)];
        
        //Fill Random Values
        Debug.Log("===============Massive 1");//visual
        for (int s = 0; s < array1.Length; s++)
        {
            array1[s] = UnityEngine.Random.Range(0, 100);
            Debug.Log(array1[s]);
        }

        //Fill Random Values
        Debug.Log("===============Massive 2");//visual      
        for (int s = 0; s < array2.Length; s++)
        {
            array2[s] = UnityEngine.Random.Range(0, 100);
            Debug.Log(array2[s]);
        }

        //Final
        int[] sortArray = new int[array1.Length + array2.Length];
        SortMerge(array1, array2, sortArray);


        // check result
        Debug.Log("==========SORT===========");
        for (int q = 0; q < sortArray.Length; q++)
        {
            Debug.Log(sortArray[q]);
        }
    }

    void Update()
    {

    }
}


