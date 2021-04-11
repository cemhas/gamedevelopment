using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopMenuController : MonoBehaviour
{
    private int pricespaceship2 = 1;
    private int pricespaceship3 = 2;

    public Button spaceship2_buy;
    public Button spaceship3_buy;

    public Button spaceship2_use;
    public Button spaceship3_use;

    public Image disabled_ship2_buy;
    public Image disabled_ship3_buy;

    //private static bool isbought2;
    //private static bool isbought3;

    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
        //CheckBalance();
        InventoryCheck();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }

    public void BuySpaceship1()
    {
        GamePreferences.SetSpaceship(1);
        Debug.Log("spaceship1 buy");
    }

    public void BuySpaceship2()
    {
        GamePreferences.SetSpaceship(2);
        spaceship2_buy.gameObject.SetActive(false);
        disabled_ship2_buy.gameObject.SetActive(false);
        //isbought2 = true;
        GamePreferences.Buy2(1);
        GamePreferences.CoinSpent(pricespaceship2);
        Debug.Log("spaceship2 buy");
    }

    public void BuySpaceship3()
    {
        GamePreferences.SetSpaceship(3);
        spaceship3_buy.gameObject.SetActive(false);
        disabled_ship3_buy.gameObject.SetActive(false);
        //isbought3 = true;
        GamePreferences.Buy3(1);
        GamePreferences.CoinSpent(pricespaceship3);
        Debug.Log("spaceship3 buy");
    }

    public void UseSpaceship1()
    {
        GamePreferences.SetSpaceship(1);
        Debug.Log("spaceship1 set");

    }
    public void UseSpaceship2()
    {
        GamePreferences.SetSpaceship(2);
        Debug.Log("spaceship2 set");

    }
    public void UseSpaceship3()
    {
        GamePreferences.SetSpaceship(3);
        Debug.Log("spaceship3 set");

    }

    public void CheckBalance()
    {
        if (GamePreferences.CurrentCoinBalance() >= pricespaceship2)
        {
            spaceship2_buy.gameObject.SetActive(true);
            disabled_ship2_buy.gameObject.SetActive(false);
        }
        else if(GamePreferences.IsBought_2() == 0)
        {
  
            spaceship2_buy.gameObject.SetActive(false);
            disabled_ship2_buy.gameObject.SetActive(true);

        } else
        {
            spaceship2_buy.gameObject.SetActive(false);
            disabled_ship2_buy.gameObject.SetActive(false);
        }



        if (GamePreferences.CurrentCoinBalance() >= pricespaceship3)
        {
            spaceship3_buy.gameObject.SetActive(true);
            disabled_ship3_buy.gameObject.SetActive(false);
        }
        else if (GamePreferences.IsBought_3() == 0)
        {
            spaceship3_buy.gameObject.SetActive(false);
            disabled_ship3_buy.gameObject.SetActive(true);
        } else
        {
            spaceship3_buy.gameObject.SetActive(false);
            disabled_ship3_buy.gameObject.SetActive(false);
        }


    }



    public void InventoryCheck()
    {
        if (GamePreferences.IsBought_2() == 1)
        {
            spaceship2_buy.gameObject.SetActive(false);
            spaceship2_use.gameObject.SetActive(true);
            disabled_ship2_buy.gameObject.SetActive(false);
        }
        else
        {
            CheckBalance();
        }

        if (GamePreferences.IsBought_3() == 1)
        {
            spaceship3_buy.gameObject.SetActive(false);
            spaceship3_use.gameObject.SetActive(true);
            disabled_ship2_buy.gameObject.SetActive(false);
        }
        else
        {
            CheckBalance();
        }
    }

   
}
