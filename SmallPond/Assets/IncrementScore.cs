using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IncrementScore : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreDisplay;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        scoreDisplay.SetText("Score: " + score);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Increment() {
        score += 100;
        scoreDisplay.SetText("Score: " + score);
        Debug.Log("Incrementing Score");
    }
}
