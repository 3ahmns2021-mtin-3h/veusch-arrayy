﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeArrays : MonoBehaviour
{
    int[] array1 = new int[4];
    int[] array2 = new int[4] { 21, 22, 23, 24 };
    int[] array3 = { 31, 32, 33, 4, 35, 36, 37 };
    string[] array4 = new string[10];
    public GameObject[] arrayColoredImagesRed;
    // Start is called before the first frame update
    void Start()
    {
       

        for (int i=0;i<array4.Length;i++)
        {
            array4[i] = "array4";
        }

        GameObject[] arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
