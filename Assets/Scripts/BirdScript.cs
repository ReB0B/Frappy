using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public float screenLowerLimit = -23;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        BirdIsVisilble();
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            rigidBody.velocity = Vector2.up * flapStrength;
        }
        if (!birdIsAlive)
        {
            logic.GameOverScreen();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
    }

    private void BirdIsVisilble()
    {
        if (transform.position.y < screenLowerLimit)
        {
            birdIsAlive = false;
        }
    }
}
