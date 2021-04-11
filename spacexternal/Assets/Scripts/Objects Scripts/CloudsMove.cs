using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsMove : MonoBehaviour
{
    [HideInInspector]
    public SpawnScriptClouds sp;

    private Rigidbody rb;


    // Start is called before the first frame update
    void Awake()
    {
        sp = GameObject.FindGameObjectWithTag("MainCamera").GetComponentInChildren<SpawnScriptClouds>();
        rb = gameObject.GetComponent<Rigidbody>();

    }

    void Start()
    {
        Move();
    }

    void FixedUpdate()
    {
        Deactivate();
    }


    public void Deactivate()
    {
        if (transform.position.x > 3000 || transform.position.x < -3000)
        {
            Destroy(gameObject);
        }
    }

    public void Move()
    {
        if(sp.leftcloud == false)
        {
            rb.AddForce(new Vector3(Random.Range(-4000, -5000), 0, 0));
        }
        else
        {
            rb.AddForce(new Vector3(Random.Range(4000, 5000), 0, 0));
        }
        
    }
}
