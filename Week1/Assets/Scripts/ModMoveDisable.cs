using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModMoveDisable : MonoBehaviour
{
    private float speed = 10f;

    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector2 temp = transform.position;
        temp.x -= speed * Time.deltaTime;

        transform.position = temp;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Left")
        {
            Destroy(gameObject);


        }
        else if (collision.gameObject.tag == "Right")
        {
            Destroy(gameObject);


        }
        else if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);

        }
    }
}
