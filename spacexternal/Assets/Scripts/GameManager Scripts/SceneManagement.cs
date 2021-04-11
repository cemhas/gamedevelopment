using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneManagement : MonoBehaviour
{
    [HideInInspector]
    public int levelscore;

    //public int current_level;

    private GameObject spaceship;

    public GameObject levelendScreen, gameoverScreen, pauseScreen;


    // Start is called before the first frame update
    void Awake()
    {
        levelscore = 0;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spaceship = GameObject.FindGameObjectWithTag("Player");
        if(SceneManager.GetActiveScene().name == "Gameplay" && levelscore != 0)
        {
            LevelScoreCheck();

        }


    }

    public void Next_Level()
    {
        GamePreferences.LevelIncrease();
        GamePreferences.GetCurrentLevel();
        Debug.Log("currentt level " + GamePreferences.current_level);
        levelscore = 0;
        Time.timeScale = 0f;
        levelendScreen.SetActive(true);
    }   

    public void GameOver_Scene()
    {
        gameoverScreen.SetActive(true);
        GamePreferences.spaceshipdestroyed = true;
        Time.timeScale = 0f;
        levelscore = 0;
        GamePreferences.SetCurrentLevel(1);
        GamePreferences.ResetSpawnIntervals();

    }

    public void NextLevel_B() // main menuye dönmeden sonraki levela geçme butonu (levelend canvas içinde)
    {
        Time.timeScale = 1f;
        Debug.Log("current level  " + GamePreferences.current_level);
        SceneManager.LoadScene("Gameplay");
        levelendScreen.SetActive(false);

    }

    public void BacktoMainMenu_B()
    {
        SceneManager.LoadScene("Mainmenu");
        gameoverScreen.SetActive(false);
        levelendScreen.SetActive(false);
        pauseScreen.SetActive(false);

    }

    public void Pause_B()
    {
        Time.timeScale = 0f;
        pauseScreen.SetActive(true);
    }

    public void Continue_B()
    {
        Time.timeScale = 1f;
        pauseScreen.SetActive(false);
    }


    void LevelScoreCheck()
    {
        if(levelscore %3 == 0)
        {
            Next_Level();
        }
    }



}
