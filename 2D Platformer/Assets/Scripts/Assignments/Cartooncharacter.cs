﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartooncharacter : MonoBehaviour
{
    string firstName = "Bloom";
    int age = 16;
    float height = 5.4f;
    bool married = false;




    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("First Name: " + firstName);
       Debug.Log("Age: " + age);
       Debug.Log("Height: " + height);
       Debug.Log("Married: " + married); 
    }

    
}
