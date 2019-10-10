using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public float speed;

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
        Vector3 temp = transform.position;
        temp.y -= speed * Time.deltaTime;
        if (temp.y < -4)
        {
            temp.y = -4;
            speed = -speed;
        }
        if (temp.y > 4)
        {
            temp.y = 4;
            speed = -speed;
        }
        transform.position = temp;
    }
}
