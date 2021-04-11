using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StonesMove_R : MonoBehaviour
{

    private float xn;
    private float yn;
    private float zn;

    // Start is called before the first frame update
    void Start()
    {
        xn = Random.Range(5f, 5.5f);
        yn = Random.Range(0.05f, 0.5f);
        zn = Random.Range(5f, 25f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Deactivate();
       
    }

    void Move()
    {


        Vector3 pmove = new Vector3(xn, yn, zn);
        transform.position -= pmove;

    }

    void Deactivate()
    {
        if (transform.position.z < 0)
        {
            Destroy(gameObject);
        }
    }
}
