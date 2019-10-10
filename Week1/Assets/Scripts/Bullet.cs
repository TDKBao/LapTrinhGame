using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }
    void Attack()
    {
        Vector2 temp = transform.position;
        temp.y += 20 * Time.deltaTime;
        transform.position = temp;

        if (temp.y > 6) Destroy(this.gameObject);
    }
    public void OnTriggerEnter2D(Collider2D collison)
    {
        if(collison.gameObject.tag =="Mod")
        {
            Destroy(gameObject);
        }
    }
}
