using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superhero : MonoBehaviour
{
    string firstName = "Flame";
    int age = 26;
    float height = 5.6f;
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
