using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool gameOver;
    void Start()
    {
        gameObject.name = "Bob";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !gameOver) myRigidBody.velocity = flapStrength * Vector2.up;
        if (transform.position.y < 9) return;
        logic.GameOver();
        gameOver = true;
    }

    private void OnCollisionEnter2D()
    {
        logic.GameOver();
        gameOver = true;
    }
}
