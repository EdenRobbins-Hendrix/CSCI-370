using System;
using Unity.VisualScripting;
using UnityEngine;

public class GetEaten : MonoBehaviour
{
    public GameObject food;
    public IncrementScore incrementScore;
    public DecrementEnergy decrementenergy;
    public AudioSource crunch;
    Boolean eaten;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    eaten = false;
    incrementScore = GameObject.FindWithTag("GameController").GetComponent<IncrementScore>();
    decrementenergy = GameObject.FindWithTag("GameController").GetComponent<DecrementEnergy>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter2D(Collision2D collision) {
        if (food != null && ! eaten){
        if (collision.rigidbody.CompareTag("Player")) {
            eaten = true;
            Destroy(food.GetComponent<SpriteRenderer>());
            crunch.Play();
            Destroy(food, 1f);
            incrementScore.Increment();
            decrementenergy.Increment();
        }
    }
    }
}
