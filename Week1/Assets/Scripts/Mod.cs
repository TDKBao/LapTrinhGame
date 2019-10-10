using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mod : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x -= speed * Time.deltaTime;
        if(temp.x < -9)
        {
            temp.x = -9;
            speed = -speed;
        }
        if (temp.x > 9)
        {
            temp.x = 9;
            speed = -speed;
        }
        transform.position = temp;
    }
}
