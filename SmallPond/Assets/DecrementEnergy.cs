using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DecrementEnergy : MonoBehaviour
{
    public float energy;
    public TMP_Text energyDisplay;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        energy = 60f;
        energyDisplay.SetText("XXXXXX");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Decrement(double distance) {
        //Debug.Log("CALLED");
        float dist = (float)distance;
        energy -= dist * 0.75f;

        energyDisplay.SetText(getText());
        //Debug.Log("Decrementing Energy");
        if (energy <= 0) {
            GameOver gameOver = (GameOver)GetComponent("GameOver");
            gameOver.EndGame();
        }
    }

    public void Increment(){
        energy += 10f;
    }

    private string getText(){
        string text = "";
        if (energy / 10 >= 5.0f){
            text = "XXXXXX";
        }
        else if (energy / 10 >= 4.0f){
            text = "XXXXX";
        }
        else if (energy / 10 >= 3.0f){
            text = "XXXX";
        }
        else if (energy / 10 >= 2.0f){
            text = "XXX";
        }
        else if (energy / 10 >= 1.0f){
            text = "XX";
        }
        else if (energy / 10 >= 0.0f){
            text = "X";
        }
        return text;

    }


}
