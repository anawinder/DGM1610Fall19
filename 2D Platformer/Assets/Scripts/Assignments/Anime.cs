using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anime : MonoBehaviour
{
    string firstName = "Skyler";
    int age = 19;
    float height = 5.7f;
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
