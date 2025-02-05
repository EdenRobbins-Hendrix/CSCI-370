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
        energyDisplay.SetText(energy.ToString());
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Decrement(double distance) {
        Debug.Log("CALLED");
        float dist = (float)distance;
        energy -= dist;

        energyDisplay.SetText(energy.ToString());
        Debug.Log("Decrementing Energy");
    }

    public void Increment(){
        energy += 10f;
    }
}
