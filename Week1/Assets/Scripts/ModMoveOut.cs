using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModMoveOut : MonoBehaviour
{
    // Start is called before the first frame update
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
    // Start is called before the first frame update


}
