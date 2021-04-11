using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform target;
    private Vector3 temp;
    public Vector3 rotation;
    public Vector3 final_position;

    [SerializeField]
    private Vector3 offsetPosition;


    // Start is called before the first frame update
    void Start()
    {
        //target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame

    void Update()
    {
        if(GamePreferences.spaceshipdestroyed == false)
        target = GameObject.FindGameObjectWithTag("Player").transform;

    }
    void LateUpdate()
    {
        FollowPlayer();

    }

    void FollowPlayer()
    {
        transform.position = target.TransformPoint(offsetPosition);
        Vector3 temp = transform.position;


        transform.rotation = Quaternion.Euler(rotation);

        final_position = transform.position;

    }
}
