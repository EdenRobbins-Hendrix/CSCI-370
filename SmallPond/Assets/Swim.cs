using System.Numerics;
using UnityEngine;

public class swim : MonoBehaviour
{
    public GameObject predator;
    public int timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0;
        InvokeRepeating("Move", 0.25f, 0.25f);   
    }

    // Update is called once per frame
    void Update()
    {
        // if the rotation is 0, it should move from left to right, 90 moves top to bottom, 180 right to left, -90 from bottom to top
        
    }

    void Move(){
        if (timer >= 20){
            Destroy(predator);
        }
        else{
            timer += 1;
            transform.Translate(new UnityEngine.Vector2(1f, 0));
        }
    }
}
