using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public float speed = 50f;
    public float maxVelocity = 4f;

    private Rigidbody2D mybody;

    [SerializeField]
    private GameObject bullet;
    
    void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }

    private void Move()
    {
        float forceX = 0f;
        float vel = Mathf.Abs(mybody.velocity.x);

        float h = Input.GetAxisRaw("Horizontal");
        if(h>0)
        {
            if (vel < maxVelocity) forceX = speed;
        }
        else if (h < 0)
        {
            if (vel < maxVelocity) forceX = -speed;
        }
        mybody.AddForce(new Vector2(forceX, 0));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GameController")
        {
            Destroy(gameObject);

        }
       
    }

}
