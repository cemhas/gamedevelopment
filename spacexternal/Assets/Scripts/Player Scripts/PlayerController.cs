using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
    //public float moveForce = 50, boostMultiplier = 2;
    Rigidbody myBody;
    public GameObject namlu;
    public GameObject bullet;

    public CollisionPlayer cp;
    
    public bool attack;

    private float counter;
    private float attack_Frequency = 0.1f;

    private float forwardSpeed = 400f;


    // Start is called before the first frame update
    void Start()
    {
        myBody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Spaceship forward movement
        Vector3 temp = transform.position;
        temp.z += forwardSpeed * Time.deltaTime;
        transform.position = temp;

        SpaceShipDirection();

    }



    void SpaceShipDirection()
    {
        myBody.velocity = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal") * 300f, CrossPlatformInputManager.GetAxis("Vertical") * 300f, 0);


        if (transform.position.x < -200f)
        {
            transform.position = new Vector3(-200f, GetComponent<Rigidbody>().transform.position.y, GetComponent<Rigidbody>().transform.position.z);

        }
        if (transform.position.x > 200f)
        {
            transform.position = new Vector3(200f, GetComponent<Rigidbody>().transform.position.y, GetComponent<Rigidbody>().transform.position.z);

        }

        if (transform.position.y < 500f)
        {
            transform.position = new Vector3(GetComponent<Rigidbody>().transform.position.x, 500f, GetComponent<Rigidbody>().transform.position.z);

        }

        if (transform.position.y > 1000f)
        {
            transform.position = new Vector3(GetComponent<Rigidbody>().transform.position.x, 1000f, GetComponent<Rigidbody>().transform.position.z);

        }

        transform.rotation = Quaternion.Euler(0, 0, CrossPlatformInputManager.GetAxis("Horizontal") * 60f);

        CheckAttackFrequency();

        BulletFired();

    }
    void BulletFired()
    {
        if (CrossPlatformInputManager.GetButton("Attack"))
        {
            if(cp.attackButton.activeInHierarchy)
            {
                if (attack)
                {
                    GameObject bulletObject = Instantiate(bullet);
                    bulletObject.transform.position = namlu.transform.position + namlu.transform.forward;
                    attack = false;
                }
            }
        }
    }

    void CheckAttackFrequency()
    {
        counter += Time.deltaTime;
        if (counter >= attack_Frequency)
        {
            counter = 0f;
            attack = true;
        }
    }
}
