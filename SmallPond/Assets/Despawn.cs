using Unity.VisualScripting;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    public Rigidbody2D self;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (self != null){
            if (self.transform.position.y < -5.5) {
                Destroy(self);
            }
        }
    }
}
