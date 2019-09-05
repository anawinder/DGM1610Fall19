using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    string firstName = "Ana";
    int age = 23;
    float height = 5.8f;
    bool married = true;




    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("First Name: " + firstName);
       Debug.Log("Age: " + age);
       Debug.Log("Height: " + height);
       Debug.Log("Married: " + married); 
    }

    
}
