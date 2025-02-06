using System;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPredator : MonoBehaviour
{
   
    public GameObject predator; // This should randomly set the rotation of the predator (as detailed in Swim.cs) as well as its location (offscreen on the side corresponding to its rotation)
    public GameObject player;
    public Boolean active;
    
    void Start()
    {
        player = GameObject.Find("Player");
        InvokeRepeating("Spawn", 0.5f, 0.60f);
        active = true; 
    }

    // Update is called once per frame
    void Update()
    {
    }

    // randomly select which axis to spawn a predator
    void Spawn() {
        if (active){
        var index = UnityEngine.Random.Range(0, 4);
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
        else {
            CancelInvoke("Spawn");
        }
    }

    float GenerateXCoordinate() {
        float initial = UnityEngine.Random.Range(-9f, 9f);
        if (initial - player.transform.position.x > 0.75 ||  initial - player.transform.position.x < -0.75) {
            initial = UnityEngine.Random.Range(-9f, 9f);
            if (initial - player.transform.position.x > 7 || initial - player.transform.position.x < -7) {
                initial = UnityEngine.Random.Range(-2f, 2f);
                initial = initial + player.transform.position.x;
            }
        }
        return initial;
    }

    float GenerateYCoordinate() {
        float initial = UnityEngine.Random.Range(-5f, 5f);
        if (initial - player.transform.position.y > 0.75 ||  initial - player.transform.position.y < -0.75) {
            initial = UnityEngine.Random.Range(-5f, 5f);
            if (initial - player.transform.position.y > 4 || initial - player.transform.position.y < -4) {
                initial = UnityEngine.Random.Range(-2f, 2f);
                initial = initial + player.transform.position.y;
            }
        }
        return initial;
    }

    // spawn predator in area just outside frame and move across camera area
    void SpawnA(){
        Instantiate(predator, new Vector2(-11f, GenerateYCoordinate()),
         Quaternion.Euler(new Vector3(0, 0, 0)));
        //Debug.Log("Instantiating Predator A");
    }

    void SpawnB(){
        Instantiate(predator, new Vector2(GenerateXCoordinate(), -7f),
         Quaternion.Euler(new Vector3(0, 0, 90)));
        //Debug.Log("Instantiating Predator B");
    }

    void SpawnC(){
        Instantiate(predator, new Vector2(11f, GenerateYCoordinate()),
         Quaternion.Euler(new Vector3(0, 0, 180)));
        //Debug.Log("Instantiating Predator C");
    }

    void SpawnD(){
        Instantiate(predator, new Vector2(GenerateXCoordinate(), 7f),
         Quaternion.Euler(new Vector3(0, 0, 270)));
        //Debug.Log("Instantiating Predator D");
    }


    
 

}
