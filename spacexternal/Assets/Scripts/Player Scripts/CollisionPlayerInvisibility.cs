using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayerInvisibility : MonoBehaviour
{
    public SceneManagement sm;
    [HideInInspector]
    public GameObject attackButton;

    [HideInInspector]
    public GameObject attackButton_transparent;

    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.FindGameObjectWithTag("Game_manager").GetComponent<SceneManagement>();
        attackButton = GameObject.FindGameObjectWithTag("AttackButton");
        attackButton_transparent = GameObject.FindGameObjectWithTag("AttackButtonT");
    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag == "Element1")
        {
            sm.levelscore++;
            Debug.Log(sm.levelscore);

        }

        if (target.gameObject.tag == "Coin")
        {
            GamePreferences.CoinGain(1);
        }

        if (target.gameObject.tag == "BulletElement")
        {
            attackButton.SetActive(true);
            attackButton_transparent.SetActive(false);


            Invoke("DeactivateButton", 10f);

        }
    }

    void DeactivateButton()
    {
        attackButton.SetActive(false);
        attackButton_transparent.SetActive(true);
    }
}
