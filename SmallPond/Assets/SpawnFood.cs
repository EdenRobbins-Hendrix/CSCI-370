using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject food;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Spawn", 1f, 7.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn() {
        Instantiate(food, new Vector2(Random.Range(-9f, 9f), 6f), Quaternion.Euler(new Vector3(0, 0, 0)));
    }
}
