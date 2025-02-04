using UnityEngine;

public class DampenFall : MonoBehaviour
{
    private float resistance;
    private Rigidbody2D food;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resistance = 0.1f;
        food = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (food.linearVelocityY + resistance < 0) {
            food.linearVelocityY += resistance * Time.fixedDeltaTime;
        }
        
    }
}
