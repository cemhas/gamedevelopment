using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelection : MonoBehaviour
{
    public GameObject[] spaceships;



    // Start is called before the first frame update
    void Start()
    {
        if (GamePreferences.GetSpaceship() == 0)
        {
            Instantiate(spaceships[0], new Vector3(1.6f, 3.91f, 20f), Quaternion.identity);
            Debug.Log("instantiate completed");
        }
        if (GamePreferences.GetSpaceship() == 1)
        {
            Instantiate(spaceships[0], new Vector3(1.6f, 3.91f, 20f), Quaternion.identity);
            Debug.Log("instantiate completed");
        }
        if (GamePreferences.GetSpaceship() == 2)
        {
            Instantiate(spaceships[1], new Vector3(1.6f, 3.91f, 20f), Quaternion.identity);
            Debug.Log("instantiate completed");
        }
        if (GamePreferences.GetSpaceship() == 3)
        {
            Instantiate(spaceships[2], new Vector3(1.6f, 3.91f, 20f), Quaternion.identity);
            Debug.Log("instantiate completed");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
