using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private float moveSpeed = 8f;
    private int directionX, directionY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        ChangeDirection();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x == 0 && transform.position.y == 0)
        {
            ChangeDirection();
            rb.velocity = new Vector2(directionX * moveSpeed, directionY * moveSpeed);
        }
    }
    public void ChangeDirection()
    {
        directionX = Random.RandomRange(-1, 1);
        directionY = Random.RandomRange(-1, 1);
    }
}
