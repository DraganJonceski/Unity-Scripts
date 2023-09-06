using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
        
    private Vector2 forwardDirection;

    private float movement;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();

        if (isAI)
        {
            forwardDirection = Vector2.left;
        }

        startPosition = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        if(!isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical1");
        }

        if (isAI)
        {
            ;
            float targetYposition = GetNewYPosition();

            transform.position = new Vector3(transform.position.x, targetYposition, transform.position.z);
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public bool isAI;
    private Ball ball;

    private float GetNewYPosition()
    {
        float result = transform.position.y;

        if(isAI)
        {
            if (BallIncoming())
                result = Mathf.MoveTowards(transform.position.y, ball.transform.position.y, speed * Time.deltaTime);
        }
        else
        {
            result = transform.position.y + movement;
        }
        return result;
    }

    private bool BallIncoming()
    {
        float dotP = Vector2.Dot(ball.rb.velocity, forwardDirection);
        return dotP < 0f;
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
