using System.Collections.Generic;
using UnityEngine;

public class SpawnPredator : MonoBehaviour
{
   
    public GameObject predator; // This should randomly set the rotation of the predator (as detailed in Swim.cs) as well as its location (offscreen on the side corresponding to its rotation)

    
    void Start()
    {
        InvokeRepeating("Spawn", 0.5f, 1.0f); 
    }

    // Update is called once per frame
    void Update()
    {
    }

    // randomly select which axis to spawn a predator
    void Spawn() {
        var index = Random.Range(0, 4);
        if (index == 0){
            SpawnA();
        }
        else if (index == 1){
            SpawnB();
        }
        else if (index == 2){
            SpawnC();
        }
        else{
            SpawnD();
        }
        
    }


    // spawn predator in area just outside frame and move across camera area
    void SpawnA(){
        Instantiate(predator, new Vector2(-10f, Random.Range(-5f, 5f)),
         Quaternion.Euler(new Vector3(0, 0, 0)));
        Debug.Log("Instantiating Predator A");
    }

    void SpawnB(){
        Instantiate(predator, new Vector2(Random.Range(-9f, 9f), -7f),
         Quaternion.Euler(new Vector3(0, 0, 90)));
        Debug.Log("Instantiating Predator B");
    }

    void SpawnC(){
        Instantiate(predator, new Vector2(10f, Random.Range(-5, 5f)),
         Quaternion.Euler(new Vector3(0, 0, 180)));
        Debug.Log("Instantiating Predator C");
    }

    void SpawnD(){
        Instantiate(predator, new Vector2(Random.Range(-9f, 9f), 7f),
         Quaternion.Euler(new Vector3(0, 0, 270)));
        Debug.Log("Instantiating Predator D");
    }


    
 

}
