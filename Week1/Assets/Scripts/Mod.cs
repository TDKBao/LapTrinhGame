using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mod : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update

    [SerializeField]
    private GameObject effect;

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x -= speed * Time.deltaTime;
        if(temp.x < -5)
        {
            temp.x = -5;
            speed = -speed;
        }
        if (temp.x > 5)
        {
            temp.x = 5;
            speed = -speed;
        }
        transform.position = temp;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="Bullet")
        {
            Destroy(gameObject);
            Destroy(Instantiate(effect, transform.position, this.transform.rotation), 2);
        }
    }
}
