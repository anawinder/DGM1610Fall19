using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villan : MonoBehaviour
{
    string firstName = "Megastorm";
    int age = 55;
    float height = 5.2f;
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
