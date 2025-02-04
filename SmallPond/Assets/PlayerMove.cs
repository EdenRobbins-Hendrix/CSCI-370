
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{
    private Vector3 mousePosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = 0;
        transform.position = mousePosition;
    }
}
