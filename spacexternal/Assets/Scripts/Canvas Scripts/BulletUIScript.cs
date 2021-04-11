using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletUIScript : MonoBehaviour
{
    private float timeAmount = 10f;
    public Image BulletUI;
    public GameObject BulletUIObj;
    private float timeLeft;

    [HideInInspector]
    public bool bulletpowerup;

    void Start()
    {
        timeLeft = timeAmount;
    
    }

void FixedUpdate()
    {
        if(bulletpowerup == true)
        {
            BulletUIObj.gameObject.SetActive(true);

            timeLeft -= Time.deltaTime;
            BulletUI.fillAmount = timeLeft / timeAmount;

        } else
        {

            BulletUIObj.gameObject.SetActive(false);
            BulletUI.fillAmount = 1f;
        }


    }
}
