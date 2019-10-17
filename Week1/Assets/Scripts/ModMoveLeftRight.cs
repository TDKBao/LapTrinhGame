using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModMoveLeftRight : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    [SerializeField]
    private GameObject modbullet;
    [SerializeField]
    private GameObject destroyMod;
    void Start()
    {
        StartCoroutine(BulletFromMod());
    }
    IEnumerator BulletFromMod()
    {
        yield return new WaitForSeconds(2);

        Vector2 temp = transform.position;
        temp.y = Random.Range(-2, 2);

        Instantiate(modbullet, temp, this.transform.rotation);

        StartCoroutine(BulletFromMod());
    }
    // Update is called once per frame
    void FixedUpdate()
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
            speed = -speed;
            Vector2 scale = transform.localScale;
            scale.x = -0.5f;
            transform.localScale = scale;

        }
        else if (collision.gameObject.tag == "Right")
        {
            speed = -speed;
            Vector2 scale = transform.localScale;
            scale.x = 0.5f;
            transform.localScale = scale;
        }
        else if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(Instantiate(destroyMod, transform.position, this.transform.rotation), 2);

        }
    }
}