using Unity.VisualScripting;
using UnityEngine;

public class DampenFall : MonoBehaviour
{
    private float resistance;
    private float factor;
    public Rigidbody2D food;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        factor = 1f;
        resistance = factor;
        }

    // Update is called once per frame
    void Update()
    {   food.linearVelocityY *= resistance;
        factor /= 1.0001f;
        if (factor > 0.05f) {
            resistance = factor;
        } 
    }
}
