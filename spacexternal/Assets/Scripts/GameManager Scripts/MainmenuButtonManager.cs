using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class MainmenuButtonManager : MonoBehaviour
{
    public Button cont_button;


    // Start is called before the first frame update
    void Start()
    {
        if(GamePreferences.GetCurrentLevel() < 2)
        {
            cont_button.gameObject.SetActive(false);
        }
        else
        {
            cont_button.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextLevel_B() // main menuye dönmeden sonraki levela geçme butonu (levelend canvas içinde)
    {
        Time.timeScale = 1f;
        Debug.Log("current level  " + GamePreferences.current_level);
        SceneManager.LoadScene("Gameplay");

    }

    public void NewGame_B() //main menu deki new game butonu, basınca tüm dataları resetler
    {
        Time.timeScale = 1f;
        GamePreferences.SetCurrentLevel(1);
        GamePreferences.ResetSpawnIntervals();
        Debug.Log("current level: " + GamePreferences.current_level);
        SceneManager.LoadScene("Gameplay");


    }

    public void ContinueGame_B() //main menudeki continue butonu
    {
        GamePreferences.GetCurrentLevel();
        SceneManager.LoadScene("Gameplay");
        Debug.Log("current level:" + GamePreferences.current_level);
        Time.timeScale = 1f;
    }

    public void Shop_B()
    {
        SceneManager.LoadScene("Shop");
        Time.timeScale = 1f;

    }

    public void Options_B()
    {
        SceneManager.LoadScene("Options");
    }

}
