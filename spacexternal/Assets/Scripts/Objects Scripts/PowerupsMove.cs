using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupsMove : MonoBehaviour
{
    private float movespeed = 3f;


    void FixedUpdate()
    {
        Move();
        Deactivate();
    }

    public void Move()
    {
        Vector3 pmove = transform.position;
        pmove.z -= movespeed;
        transform.position = pmove;
    }

    public void Deactivate()
    {
        if (transform.position.z < 0)
        {
            Destroy(gameObject);
        }
    }
}
