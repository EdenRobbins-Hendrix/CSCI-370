using System.Numerics;
using UnityEngine;

public class swim : MonoBehaviour
{
    public GameObject predator;
    public int timer;
    private bool recentlyMade;
    public bool active;
    private int frames;
    private bool triggered;
    public AudioSource crunch;
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
        frames++;
        if (frames % 10 == 0) { //If the remainder of the current frame divided by 10 is 0 run the function.
            triggered = false;
    }
        // if the rotation is 0, it should move from left to right, 90 moves top to bottom, 180 right to left, -90 from bottom to top
        Move();}


    }
    
    void Move(){
        if (!recentlyMade && (transform.position.x > 12 || transform.position.x < -12 || transform.position.y > 7 || transform.position.y < -7)){
            Destroy(predator);
        }
        else{
            transform.Translate(new UnityEngine.Vector2(0.01f, 0));

        }
    }

    

    void OnTriggerEnter2D(Collider2D collider) {
        //Debug.Log("Triggered");
		GameObject otherObject = collider.gameObject;
		if (otherObject.name == "Player" && triggered){
                GameOver gameOver = (GameOver)GameObject.FindWithTag("GameController").GetComponent("GameOver");
                gameOver.EndGame();
                //Debug.Log("Predator triggered with: " + otherObject);
                crunch.Play();
        }
    triggered = true;
    }

}
