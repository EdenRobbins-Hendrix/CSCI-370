using UnityEngine;

public class SpawnPredator : MonoBehaviour
{
   
    public GameObject predator; // This should randomly set the rotation of the predator (as detailed in Swim.cs) as well as its location (offscreen on the side corresponding to its rotation)
   // public float timerLength;
    //float timer;
    void Start()
    {
        //timer = 0f;
        InvokeRepeating("Spawn", 1.5f, 2.0f); 
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
        Instantiate(predator, new Vector2(Random.Range(0, 3f), Random.Range(0, 3f)), Quaternion.identity);
        Debug.Log("Instantiating Predator");
    }


    
 

}
