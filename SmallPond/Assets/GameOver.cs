using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public TMP_Text endText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EndGame() {
        endText.SetText("Game Over");
        HaltAll();
    }

    private void HaltAll() {
        SpawnPredator spawnPredator = (SpawnPredator)GetComponent("SpawnPredator");
        spawnPredator.active = false;
        SpawnFood spawnFood = (SpawnFood)GetComponent("SpawnFood");
        spawnFood.active = false;
        PlayerMove playerMove = (PlayerMove)GameObject.FindWithTag("Player").GetComponent("PlayerMove");
        playerMove.active = false;
        GameObject[] predators = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject predator in predators) {
            swim swim = (swim)predator.GetComponent("Swim");
            swim.active = false;
        }
    }
}
