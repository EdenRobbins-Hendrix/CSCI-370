using System.Numerics;
using UnityEngine;

public class swim : MonoBehaviour
{
    public GameObject predator;
    public int timer;
    private bool recentlyMade;
    public bool active;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        active = true;
        timer = 0;
        recentlyMade = true;
    }

    // Update is called once per frame
    void Update()
    {   if (active){
        timer++;
        if (timer > 500) {
            recentlyMade = false;
        }
        // if the rotation is 0, it should move from left to right, 90 moves top to bottom, 180 right to left, -90 from bottom to top
        Move();}
    }

    void Move(){
        if (!recentlyMade && (transform.position.x > 12 || transform.position.x < -12 || transform.position.y > 7 || transform.position.y < -7)){
            Destroy(predator);
        }
        else{
            transform.Translate(new UnityEngine.Vector2(0.04f, 0));
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
		GameObject otherObject = collision.gameObject;
		if (otherObject.CompareTag("Player")){
                GameOver gameOver = (GameOver)GameObject.FindWithTag("GameController").GetComponent("GameOver");
                gameOver.EndGame();
            //Debug.Log("Predator triggered with: " + otherObject);
        }
    }

}
