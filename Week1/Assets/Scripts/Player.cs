using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveForece = 20f;
    public float maxVelocity = 4f;
    public float jumForce = 400f;
    public bool grounded;
    private Rigidbody2D myBody;
    private Animator anim;
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        PlayerWalkKeyBoard();
    }
    void PlayerWalkKeyBoard()
    {
        float forceX = 0f;
        float forceY = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);
        float h = Input.GetAxisRaw("Horizontal");

        if(h>0)
        {
            anim.SetBool("Walk", true);
            if(vel < maxVelocity)
            {
                forceX = moveForece;
            }
            Vector3 v = transform.localScale;
            v.x = 1f;
            transform.localScale = v;
        }
        else if (h<0)
        {
            anim.SetBool("Walk", true);
            if (vel<maxVelocity)
            {
                forceX = -moveForece;
            }
            Vector3 v = transform.localScale;
            v.x = -1f;
            transform.localScale = v;
        }
        else if(h==0)
        {
            anim.SetBool("Walk", false);

        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (grounded)
            {
                forceY = jumForce;
                grounded = false;
            }
        }
        myBody.AddForce(new Vector2(forceX, forceY));

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        { grounded = true; }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 4.24f)
        //{
        //    transform.Translate(Vector3.up * speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -4.24f)
        //{
        //    transform.Translate(Vector3.down * speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -9.78f)
        //{
        //    transform.Translate(Vector3.left * speed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 9.78f)
        //{
        //    transform.Translate(Vector3.right * speed * Time.deltaTime);
        //}
    }
}
