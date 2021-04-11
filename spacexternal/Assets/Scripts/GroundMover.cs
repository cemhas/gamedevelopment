using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMover : MonoBehaviour
{
    [HideInInspector]
    public GameObject[] grounds;

    [HideInInspector]
    public float lastGroundZ;

    // Start is called before the first frame update
    void Awake()
    {
        grounds = GameObject.FindGameObjectsWithTag("Platform");

        lastGroundZ = grounds[0].transform.position.z;

        for(int i = 1; i < grounds.Length; i++)
        {
            if(lastGroundZ < grounds[i].transform.position.z)
            {
                lastGroundZ = grounds[i].transform.position.z;
            }
        }
    }


    void OnTriggerEnter(Collider target)
    {
       if(target.tag == "Platform")
        {
            Vector3 temp = target.transform.position;
            //float length = ((BoxCollider)target).size.y;

            float length = 10000;

            temp.z = lastGroundZ + length;

            target.transform.position = temp;

            lastGroundZ = temp.z;
        }
    }
}
