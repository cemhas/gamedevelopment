using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetsMove : MonoBehaviour
{

    private float movespeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

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
        if(transform.position.z < 0)
        {
            Destroy(gameObject);
        }
    }
}
