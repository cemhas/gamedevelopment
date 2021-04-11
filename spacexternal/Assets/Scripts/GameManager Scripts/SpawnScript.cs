using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    private GameObject spawnPos;

    public GameObject[] planets;
    public GameObject[] stonesl;
    public GameObject[] stonesr;
    public GameObject[] powerups;
    public GameObject[] trees;
    public GameObject[] platforms;

    public GameObject element;
    public GameObject coin;
    private Animator coinAnim;
    public GameObject flower;

    private float startDelay = 2.5f;



    void Awake()
    {
        GamePreferences.GetCurrentLevel();

        spawnPos = gameObject;


        SpawnIntervalDetermine();



    }

    // Start is called before the first frame update
    void Start()
    {
        if(GamePreferences.GetCurrentLevel() < 3)
        {
            InvokeRepeating("SpawnPlanets", startDelay, GamePreferences.sIntervalPlanets);
            InvokeRepeating("SpawnElements", startDelay, GamePreferences.sIntervalElements);
            InvokeRepeating("SpawnStones", startDelay, GamePreferences.sIntervalStones);
            InvokeRepeating("SpawnPowerups", startDelay, GamePreferences.sIntervalPowerups);
            InvokeRepeating("SpawnOtherObjects", startDelay, GamePreferences.sIntervalOtherobjects);
            InvokeRepeating("SpawnCoins", startDelay, GamePreferences.sIntervalCoins);
        }
        else
        {
            InvokeRepeating("SpawnPlanets", startDelay, GamePreferences.GetSpawnIntervalPlanets());
            InvokeRepeating("SpawnElements", startDelay, GamePreferences.GetSpawnIntervalElements());
            InvokeRepeating("SpawnStones", startDelay, GamePreferences.GetSpawnIntervalStones());
            InvokeRepeating("SpawnPowerups", startDelay, GamePreferences.GetSpawnIntervalPowerups());
            InvokeRepeating("SpawnOtherObjects", startDelay, GamePreferences.GetSpawnIntervalOtherobjects());
            InvokeRepeating("SpawnCoins", startDelay, GamePreferences.GetSpawnIntervalCoins());
        }
        

        Debug.Log("spawnplanets value is: " + GamePreferences.sIntervalPlanets);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnIntervalDetermine()
    {
        if(GamePreferences.GetCurrentLevel() %3 == 0)
        {
            GamePreferences.ChangeSpawnIntervalPlanets();
            GamePreferences.ChangeSpawnIntervalElements();
            GamePreferences.ChangeSpawnIntervalStones();
            GamePreferences.ChangeSpawnIntervalPowerups();
            GamePreferences.ChangeSpawnIntervalOtherobjects();
            GamePreferences.ChangeSpawnIntervalCoins();

        }
    }

    void SpawnPlanets()
    {
        int randomPlanetIndex = Random.Range(0, planets.Length);
        GameObject planetObj = Instantiate(planets[randomPlanetIndex],
            new Vector3(Random.Range(gameObject.transform.position.x * -3.5f, gameObject.transform.position.x * 3.5f),
            gameObject.transform.position.y,
            Random.Range(gameObject.transform.position.z * 1f, gameObject.transform.position.z * 1f)), Quaternion.identity);
    }

    

    void SpawnStones()
    {
        int randomStoneIndex = Random.Range(0, stonesl.Length);
        GameObject stoneObj = Instantiate(stonesl[randomStoneIndex],
            new Vector3(Random.Range(gameObject.transform.position.x * 10f, gameObject.transform.position.x * 20f),
            Random.Range(gameObject.transform.position.y * 0.9f, gameObject.transform.position.y * 1.1f),
            Random.Range(gameObject.transform.position.z * 1f, gameObject.transform.position.z * 1f)),
            Quaternion.identity);

        int randomStoneIndex1 = Random.Range(0, stonesr.Length);
        GameObject stoneObj1 = Instantiate(stonesr[randomStoneIndex],
            new Vector3(Random.Range(gameObject.transform.position.x * -20f, gameObject.transform.position.x * -10f),
            Random.Range(gameObject.transform.position.y * 0.9f, gameObject.transform.position.y * 1.1f),
            Random.Range(gameObject.transform.position.z * 1f, gameObject.transform.position.z * 1f)),
            Quaternion.identity);
    }

    void SpawnOtherObjects()
    {
        int rand_number_obj = Random.Range(0, 3);

        if (rand_number_obj == 0)
        {
            int rand = Random.Range(0, 3);
            GameObject flowerObj = Instantiate(flower, new Vector3(
                Random.Range(platforms[rand].transform.position.x * -1f, platforms[rand].transform.position.x * 1f),
                platforms[rand].transform.position.y,
                Random.Range(platforms[rand].transform.position.z * 0.5f, platforms[rand].transform.position.z * 2)),
                Quaternion.Euler(-90f, Random.Range(0, 180), Random.Range(0, 180)));

            flowerObj.transform.parent = platforms[rand].transform;

        }
        else if (rand_number_obj == 1)
        {
            int rand = Random.Range(0, 3);
            GameObject treeObj = Instantiate(trees[0], new Vector3(
                Random.Range(platforms[rand].transform.position.x * -1f, platforms[rand].transform.position.x * 1f),
                platforms[rand].transform.position.y,
                Random.Range(platforms[rand].transform.position.z * 0.5f, platforms[rand].transform.position.z * 2)),
                Quaternion.Euler(-90f, Random.Range(0, 180), Random.Range(0, 180)));

            treeObj.transform.parent = platforms[rand].transform;

        }
        else
        {
            int rand = Random.Range(0, 3);
            GameObject treeObj = Instantiate(trees[1], new Vector3(
                Random.Range(platforms[rand].transform.position.x * -1f, platforms[rand].transform.position.x * 1f),
                platforms[rand].transform.position.y,
                Random.Range(platforms[rand].transform.position.z * 0.5f, platforms[rand].transform.position.z * 2)),
                Quaternion.Euler(-90f, Random.Range(0, 180), Random.Range(0, 180)));

            treeObj.transform.parent = platforms[rand].transform;
        }

        /*int rand_number_cloud = Random.Range(0, 30);

        if (rand_number_cloud == 0)
        {
            GameObject cloudObj = Instantiate(clouds[0],
                new Vector3(Random.Range(gameObject.transform.position.x * -2f, gameObject.transform.position.x * -1f),
                Random.Range(gameObject.transform.position.y * 0.9f, gameObject.transform.position.y * 1.1f),
                Random.Range(gameObject.transform.position.z * 1f, gameObject.transform.position.z * 1f)),
                Quaternion.Euler(-90f, -45f, Random.Range(50, 55)));


            leftcloud = true;

        }
        else if (rand_number_cloud == 1)
        {
            GameObject cloudObj = Instantiate(clouds[1],
                new Vector3(Random.Range(gameObject.transform.position.x * 1f, gameObject.transform.position.x * 2f),
                Random.Range(gameObject.transform.position.y * 0.9f, gameObject.transform.position.y * 1.1f),
                Random.Range(gameObject.transform.position.z * 1f, gameObject.transform.position.z * 1f)),
                Quaternion.Euler(-90f, 25, Random.Range(140, 160)));


            leftcloud = false;
        }*/
    }

    void SpawnElements()
    {

        int rand = Random.Range(0, 3);
        GameObject elementObj = Instantiate(element, new Vector3(
            Random.Range(-200f, 200f),
            Random.Range(500f, 1000f),
            Random.Range(platforms[rand].transform.position.z * 1f, platforms[rand].transform.position.z * 2)),
            Quaternion.identity);

    }

    void SpawnPowerups()
    {

        /*int randomPowerupsIndex = Random.Range(0, powerups.Length);
        GameObject powerupObj = Instantiate(powerups[randomPowerupsIndex],
            new Vector3(Random.Range(gameObject.transform.position.x * -3.5f, gameObject.transform.position.x * 3.5f),
            gameObject.transform.position.y,
            Random.Range(gameObject.transform.position.z * 1f, gameObject.transform.position.z * 1f)),
            Quaternion.identity);*/

        int randomPowerupsIndex = Random.Range(0, powerups.Length);
        int rand = Random.Range(0, 3);
        GameObject powerupObj = Instantiate(powerups[randomPowerupsIndex],
            new Vector3(
            Random.Range(-200f, 200f),
            Random.Range(500f, 1000f),
            Random.Range(platforms[rand].transform.position.z * 1f, platforms[rand].transform.position.z * 2)),
            Quaternion.identity);

    }



    void SpawnCoins()
    {


            int rand = Random.Range(0, 3);
            GameObject coinObj = Instantiate(coin,
            new Vector3(
            Random.Range(-200f, 200f),
            Random.Range(500f, 1000f),
            Random.Range(platforms[rand].transform.position.z * 1f, platforms[rand].transform.position.z * 2)),
            Quaternion.identity);

            coinAnim = coinObj.GetComponent<Animator>();

            
            

    }
}


