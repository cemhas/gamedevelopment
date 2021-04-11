using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementUIScript : MonoBehaviour
{


    [SerializeField]
    private Image ElementUI;

    // Start is called before the first frame update
    void Start()
    {
        ElementUI.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FillElementMeter()
    {

        ElementUI.fillAmount += 0.35f;
    }
}
