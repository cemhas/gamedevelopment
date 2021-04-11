using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayCanvasManager : MonoBehaviour
{
    public Text coinAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        coinAmount.text = GamePreferences.CurrentCoinBalance().ToString();
    }
}
