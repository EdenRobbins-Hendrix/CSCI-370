using System;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public Boolean active;
    public GameObject food;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        active = true;
        InvokeRepeating("Spawn", 1f, 8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn() {
        if (active){
        Instantiate(food, new Vector2(UnityEngine.Random.Range(-9f, 9f), 6f), Quaternion.Euler(new Vector3(0, 0, 0)));}
        else {
            CancelInvoke("Spawn");
        }
    }
}
