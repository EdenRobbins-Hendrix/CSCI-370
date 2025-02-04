using System.Numerics;
using UnityEngine;

public class swim : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Move", 0.25f, 0.25f);   
    }

    public float speed;
    // Update is called once per frame
    void Update()
    {
        // if the rotation is 0, it should move from left to right, 90 moves top to bottom, 180 right to left, -90 from bottom to top
        
    }

    void Move(){
        
        transform.Translate(new UnityEngine.Vector2(1, 0));
    }
}
