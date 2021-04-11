using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScriptClouds : MonoBehaviour
{

    public GameObject[] clouds;

    private float startDelay = 2.5f;

    [HideInInspector]
    public bool leftcloud;

    private GameObject spawnPos;


    void Awake()
    {
        GamePreferences.GetCurrentLevel();

        spawnPos = gameObject;


        SpawnIntervalDetermine();



    }
    // Start is called before the first frame update
    void Start()
    {
        if (GamePreferences.GetCurrentLevel() < 3)
        {
            InvokeRepeating("SpawnClouds", startDelay, GamePreferences.sIntervalOtherobjects);

        }
        else
        {
            InvokeRepeating("SpawnClouds", startDelay, GamePreferences.GetSpawnIntervalOtherobjects());

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnIntervalDetermine()
    {
        if (GamePreferences.GetCurrentLevel() % 3 == 0)
        {
            GamePreferences.ChangeSpawnIntervalOtherobjects();

        }
    }

    void SpawnClouds()
    {
        int rand_number_cloud = Random.Range(0, 30);

        if (rand_number_cloud == 0)
        {
            GameObject cloudObj = Instantiate(clouds[0],
                new Vector3(Random.Range(gameObject.transform.position.x * -2f, gameObject.transform.position.x * -1f),
                Random.Range(gameObject.transform.position.y * 1.3f, gameObject.transform.position.y * 1.5f),
                (gameObject.transform.position.z)),
                Quaternion.Euler(-90f, -45f, Random.Range(50, 55)));


            leftcloud = true;

        }
        else if (rand_number_cloud == 1)
        {
            GameObject cloudObj = Instantiate(clouds[1],
                new Vector3(Random.Range(gameObject.transform.position.x * 1f, gameObject.transform.position.x * 2f),
                Random.Range(gameObject.transform.position.y * 1.4f, gameObject.transform.position.y * 1.7f),
                (gameObject.transform.position.z)),
                Quaternion.Euler(-90f, 25, Random.Range(140, 160)));


            leftcloud = false;
        }
    }
}
