using Unity.VisualScripting;
using UnityEngine;

public class GetEaten : MonoBehaviour
{
    public GameObject food;
    public IncrementScore incrementScore;
    public DecrementEnergy decrementenergy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    incrementScore = GameObject.FindWithTag("GameController").GetComponent<IncrementScore>();
    decrementenergy = GameObject.FindWithTag("GameController").GetComponent<DecrementEnergy>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter2D(Collision2D collision) {
        if (food != null){
        if (collision.rigidbody.CompareTag("Player")) {
            Destroy(food);
            incrementScore.Increment();
            decrementenergy.Increment();
        }
    }
    }
}
