using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private float speed = 1000f;
    private float lifeDuration = 10f;

    private float lifeTimer;

    //public GameObject stone;



    // Start is called before the first frame update
    void Start()
    {
        lifeTimer = lifeDuration;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.z += speed * Time.deltaTime;
        transform.position = temp;

        //transform.position += transform.forward * speed * Time.deltaTime;

        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision carptigim_nesne)
    {
        if (carptigim_nesne.gameObject.tag == "Stone")
        {
            Destroy(carptigim_nesne.gameObject);
            Destroy(gameObject);

            //GÖKTAŞI PATLATMA ANİMASYONU

        }

        if (carptigim_nesne.gameObject.tag == "Planet")
        {
            Destroy(gameObject);

            //MERMİ GÖMÜLME ANİMASYONU
        }
    }



}
