using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float moveForece = 20f;
    public float maxVelocity = 4f;
    public float jumForce = 400f;
    public bool grounded;
    private Rigidbody2D myBody;
    private Animator anim;
    private bool MoveLeft, MoveRight;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        PlayerJoyStick();
    }
    public void setMoveLeft(bool left)
    {
        MoveLeft = left;
        MoveRight = !left;
    }

    public void StopMoving()
    {
        MoveLeft = false;
        MoveRight = false;
    }
    void PlayerJoyStick()
    {
        float forceX = 0f;
        float forceY = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);
        if (MoveLeft)
        {
            if (vel < maxVelocity)
            {
                forceX = -moveForece;
            }
            Vector3 v = transform.localScale;
            v.x = -1f;
            transform.localScale = v;
        }
        else if (MoveRight)
        {
            if (vel < maxVelocity)
            {
                forceX = moveForece;
            }
            Vector3 v = transform.localScale;
            v.x = 1f;
            transform.localScale = v;
        }
        myBody.AddForce(new Vector2(forceX, forceY));


    }
}
