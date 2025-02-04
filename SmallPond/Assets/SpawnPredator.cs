using System.Collections.Generic;
using UnityEngine;

public class SpawnPredator : MonoBehaviour
{
   
    public GameObject predator; // This should randomly set the rotation of the predator (as detailed in Swim.cs) as well as its location (offscreen on the side corresponding to its rotation)
   // public float timerLength;
    //float timer;
    List<Vector3> l = new List<Vector3>();

    
    void Start()
    {
        //timer = 0f;
        InvokeRepeating("Spawn", 2.0f, 2.5f); 
        // Add elements to the list
    

        // Create a new list of integers

    }

    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;
        //if(timer > timerLength) {
          //  Instantiate(predator, new Vector2(Random.Range(0, 3f), Random.Range(0, 3f)), Quaternion.identity);
            //Debug.Log("Instantiating Predator");
            //timer = 0f;
       // } 
    }

    void Spawn() {

        Instantiate(predator, new Vector2(-10f, Random.Range(-5f, 5f)),
         Quaternion.Euler(new Vector3(0, 0, 0)));
        Debug.Log("Instantiating Predator");

        Instantiate(predator, new Vector2(Random.Range(-9f, 9f), -7f),
         Quaternion.Euler(new Vector3(0, 0, 90)));
        Debug.Log("Instantiating Predator");

        Instantiate(predator, new Vector2(10f, Random.Range(-5, 5f)),
         Quaternion.Euler(new Vector3(0, 0, 180)));
        Debug.Log("Instantiating Predator");

        Instantiate(predator, new Vector2(Random.Range(-9f, 9f), 7f),
         Quaternion.Euler(new Vector3(0, 0, 270)));
        Debug.Log("Instantiating Predator");
    }


    
 

}
