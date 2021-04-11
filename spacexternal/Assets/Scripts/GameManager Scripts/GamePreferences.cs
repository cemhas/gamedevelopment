using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePreferences
{
    public static string currentLevel = "CurrentLevel";
    public static string spaceshipIndex = "SpaceshipIndex";
    public static string Inventory2 = "Inventory2";
    public static string Inventory3 = "Inventory3";
    public static string Wallet = "Wallet";

    public static string spawnIntervalPlanets = "SpawnIntervalPlanets";
    public static string spawnIntervalElements = "SpawnIntervalElements";
    public static string spawnIntervalStones = "SpawnIntervalStones";
    public static string spawnIntervalPowerups = "SpawnIntervalPowerups";
    public static string spawnIntervalOtherobjects = "SpawnIntervalOtherobjects";
    public static string spawnIntervalCoins = "SpawnIntervalCoins";

    public static float sIntervalPlanets = 1f;
    public static float sIntervalElements = 4f;
    public static float sIntervalStones = 1.75f;
    public static float sIntervalPowerups = 5f;
    public static float sIntervalOtherobjects = 0.5f;
    public static float sIntervalCoins = 2f;



    public static int money;
    public static int current_level = 1;

    public static bool spaceshipdestroyed;

    //LEVEL DETERMINE

    public static int GetCurrentLevel()
    {
        return PlayerPrefs.GetInt(GamePreferences.currentLevel);
    }

    public static void LevelIncrease()
    {
        current_level += 1;
        PlayerPrefs.SetInt(GamePreferences.currentLevel, current_level);
    }

    public static void SetCurrentLevel(int level)
    {
        PlayerPrefs.SetInt(GamePreferences.currentLevel, level);
    }


    //SPAWN INTERVAL DETERMINE

    public static float GetSpawnIntervalPlanets()
    {
        return PlayerPrefs.GetFloat(GamePreferences.spawnIntervalPlanets);
    }

    public static void ChangeSpawnIntervalPlanets()
    {
        sIntervalPlanets *= 1.1f;
        PlayerPrefs.SetFloat(GamePreferences.spawnIntervalPlanets, sIntervalPlanets);
    }

    public static float GetSpawnIntervalElements()
    {
        return PlayerPrefs.GetFloat(GamePreferences.spawnIntervalElements);
    }

    public static void ChangeSpawnIntervalElements()
    {
        sIntervalElements *= 1.1f;
        PlayerPrefs.SetFloat(GamePreferences.spawnIntervalElements, sIntervalElements);
    }

    public static float GetSpawnIntervalStones()
    {
        return PlayerPrefs.GetFloat(GamePreferences.spawnIntervalStones);
    }

    public static void ChangeSpawnIntervalStones()
    {
        sIntervalStones *= 1.1f;
        PlayerPrefs.SetFloat(GamePreferences.spawnIntervalStones, sIntervalStones);
    }

    public static float GetSpawnIntervalPowerups()
    {
        return PlayerPrefs.GetFloat(GamePreferences.spawnIntervalPowerups);
    }

    public static void ChangeSpawnIntervalPowerups()
    {
        sIntervalPowerups *= 1.1f;
        PlayerPrefs.SetFloat(GamePreferences.spawnIntervalPowerups, sIntervalPowerups);
    }

    public static float GetSpawnIntervalOtherobjects()
    {
        return PlayerPrefs.GetFloat(GamePreferences.spawnIntervalOtherobjects);
    }

    public static void ChangeSpawnIntervalOtherobjects()
    {
        sIntervalOtherobjects *= 1.1f;
        PlayerPrefs.SetFloat(GamePreferences.spawnIntervalOtherobjects, sIntervalOtherobjects);
    }

    public static float GetSpawnIntervalCoins()
    {
        return PlayerPrefs.GetFloat(GamePreferences.spawnIntervalCoins);
    }

    public static void ChangeSpawnIntervalCoins()
    {
        sIntervalCoins *= 1.1f;
        PlayerPrefs.SetFloat(GamePreferences.spawnIntervalCoins, sIntervalCoins);
    }

    //SPAWN INTERVAL RESET FOR NEW GAME

    public static void ResetSpawnIntervals()
    {
        sIntervalPlanets = 2f;
        PlayerPrefs.SetFloat(GamePreferences.spawnIntervalPlanets, sIntervalPlanets);

        sIntervalElements = 4f;
        PlayerPrefs.SetFloat(GamePreferences.spawnIntervalElements, sIntervalElements);

        sIntervalStones = 1.75f;
        PlayerPrefs.SetFloat(GamePreferences.spawnIntervalStones, sIntervalStones);

        sIntervalPowerups = 5f;
        PlayerPrefs.SetFloat(GamePreferences.spawnIntervalPowerups, sIntervalPowerups);

        sIntervalOtherobjects = 0.5f;
        PlayerPrefs.SetFloat(GamePreferences.spawnIntervalOtherobjects, sIntervalOtherobjects);

        sIntervalCoins = 2f;
        PlayerPrefs.SetFloat(GamePreferences.spawnIntervalCoins, sIntervalCoins);
    }

    //SPACESHIP SELECTION

    public static int GetSpaceship()
    {
        spaceshipdestroyed = false;
        return PlayerPrefs.GetInt(GamePreferences.spaceshipIndex);
    }

    public static void SetSpaceship(int state)
    {
        PlayerPrefs.SetInt(GamePreferences.spaceshipIndex, state);
    }


    //WALLET

    public static void CoinGain(int amount)
    {
        money += amount;
        PlayerPrefs.SetInt(GamePreferences.Wallet, money);
    }

    public static void CoinSpent(int price)
    {
        money -= price;
        PlayerPrefs.SetInt(GamePreferences.Wallet, money);
    }

    public static int CurrentCoinBalance()
    {
        return PlayerPrefs.GetInt(GamePreferences.Wallet);
    }



    //INVENTORY

    public static void Buy2(int bought)
    {
        PlayerPrefs.SetInt(GamePreferences.Inventory2, bought);
    }

    public static int IsBought_2()
    {
        return PlayerPrefs.GetInt(GamePreferences.Inventory2);
    }
    public static void Buy3(int bought)
    {
        PlayerPrefs.SetInt(GamePreferences.Inventory3, bought);
    }

    public static int IsBought_3()
    {
        return PlayerPrefs.GetInt(GamePreferences.Inventory3);
    }

   
}
