using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayer : MonoBehaviour
{
    public GameObject[] explodes;

    public GameObject invisibility;

    public SceneManagement sm;
    public ElementUIScript eui;
    public BulletUIScript bui;

    [HideInInspector]
    public GameObject attackButton;

    [HideInInspector]
    public GameObject attackButton_transparent;





    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.FindGameObjectWithTag("Game_manager").GetComponent<SceneManagement>();
        eui = GameObject.FindGameObjectWithTag("M_canvas").GetComponent<ElementUIScript>();
        bui = GameObject.FindGameObjectWithTag("M_canvas").GetComponent<BulletUIScript>();
        attackButton = GameObject.FindGameObjectWithTag("AttackButton");
        attackButton_transparent = GameObject.FindGameObjectWithTag("AttackButtonT");
        attackButton.SetActive(false);
        attackButton_transparent.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //çarpınca öldüğümüz nesneler

    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "Planet")
        {
            gameObject.SetActive(false);
            //GEMİ PATLAMA ANİMASYONU

            sm.GameOver_Scene();
  
        }
        if (target.gameObject.tag == "Stone")
        {
            gameObject.SetActive(false);
            //GEMİ PATLAMA ANİMASYONU
            sm.GameOver_Scene();
     
        }
    }

    //Power-uplar

    void OnTriggerEnter(Collider target)
    {
        /*if(carptigim_nesne2.tag == "Powerup-Slow")
        {
            pm1.movespeed = 0f;
            pm2.movespeed = 0f;
            pm3.movespeed = 0f;

        }*/

        if (target.tag == "Powerup-Destroy")
        {

            GameObject[] explodes = GameObject.FindGameObjectsWithTag("Planet");
            foreach (GameObject planet in explodes)
            GameObject.Destroy(planet);

            //GEZEGEN PATLATMA ANİMASYONU
        }


        if (target.tag == "Powerup-DestroyS")
        {

            GameObject[] explodes = GameObject.FindGameObjectsWithTag("Stone");
            foreach (GameObject stone in explodes)
            GameObject.Destroy(stone);

            //GÖKTAŞI PATLATMA ANİMASYONU
        }

        if (target.tag == "Powerup-Invisibility")
        {
            Invoke("ActivateIsTrigger", 0.1f);
            Invoke("DectivateIsTrigger", 5f);
            GameObject.Destroy(target);


        }

        if (target.tag == "Element1")
        {
            sm.levelscore++;
            Debug.Log("level score is" + sm.levelscore);
            GameObject.Destroy(target);
            eui.FillElementMeter();


        }

        if (target.tag == "BulletElement")
        {
            attackButton.SetActive(true);
            attackButton_transparent.SetActive(false);
            GameObject.Destroy(target);
            bui.bulletpowerup = true;




            Invoke("DeactivateButton", 10f);

        }

        if(target.tag == "Coin")
        {
            GamePreferences.CoinGain(1);
            GameObject.Destroy(target);
        }

    }

    void ActivateIsTrigger()
    {
        gameObject.GetComponent<Collider>().isTrigger = true;
        //gameObject.GetComponent<Collider>().enabled = false;
        transform.Find("invisibility").gameObject.SetActive(true);
    }

    void DectivateIsTrigger()
    {
        gameObject.GetComponent<Collider>().isTrigger = false;
        //gameObject.GetComponent<Collider>().enabled = true;
        transform.Find("invisibility").gameObject.SetActive(false);
    }

    void DeactivateButton()
    {
        attackButton.SetActive(false);
        attackButton_transparent.SetActive(true);
        bui.bulletpowerup = false;

    }


}
