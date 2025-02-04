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
        UnityEngine.Vector3 rot = transform.eulerAngles;
        if (rot == new UnityEngine.Vector3(0,0,0)){
            Debug.Log("Match! 0");
        } 
        if (rot == new UnityEngine.Vector3(0,0,90)){
            Debug.Log("Match! 90");
        }
        if (rot == new UnityEngine.Vector3(0,0,180)){
            Debug.Log("Match! 180");
        }
        if (rot == new UnityEngine.Vector3(0,0,270)){
            Debug.Log("Match! 270");
        }
        
        transform.Translate(new UnityEngine.Vector2(1, 0));
    }
}
