
using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{
    private Vector3 mousePosition;
    public DecrementEnergy decrementenergy;
    private float lastx;
    private float lasty;
    public Boolean active;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        active = true;
        decrementenergy = GameObject.FindWithTag("GameController").GetComponent<DecrementEnergy>();
    }
    // Update is called once per frame
    void Update()
    {
        if (active){
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = 0;
        if (mousePosition.y > -4 || mousePosition.y < 4 || mousePosition.x > -9.25f || mousePosition.x < 9.25f) {
            transform.position = mousePosition;
        }
        double distance = Math.Pow(mousePosition.y - lasty, 2) + Math.Pow(mousePosition.x - lastx, 2);
        distance = Math.Sqrt(distance);
        //Debug.Log("moved "+ distance);
        lasty = mousePosition.y;
        lastx = mousePosition.x;

        decrementenergy.Decrement(distance);
        }
        else {
            transform.position = new Vector3(lastx, lasty, 0);
        }
        

    }

    void OnCollisionEnter2D(Collision2D collision){
        GameObject otherObject = collision.gameObject;
        //Debug.Log("Player collided with: " + otherObject);
    }
    void OnTriggerEnter2D(Collider2D collider) {
		GameObject otherObject = collider.gameObject;
		//Debug.Log("Player triggered with: " + otherObject);
    }
}
