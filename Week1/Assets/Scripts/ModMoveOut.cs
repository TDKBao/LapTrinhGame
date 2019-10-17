using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModMoveOut : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    [SerializeField]
    private GameObject plane;

    void Start()
    {
        StartCoroutine(CreatePlane());
    }
    IEnumerator CreatePlane()
    {
        yield return new WaitForSeconds(2);

        Vector2 temp = transform.position;
        temp.y = Random.Range(-2, 2);

        Instantiate(plane, temp, this.transform.rotation);

        StartCoroutine(CreatePlane());
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
    }
    // Start is called before the first frame update


}
