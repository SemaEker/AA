using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaCemberKod : MonoBehaviour
{
    public GameObject kucukCember;
    GameObject OyunYonetici;

    void Start()
    {
        OyunYonetici = GameObject.FindGameObjectWithTag("oyunyoneticitag");
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            KucukCemberOlustur();       
        }
        
    }
    void KucukCemberOlustur()
    {
        Instantiate(kucukCember, transform.position, transform.rotation);
        OyunYonetici.GetComponent<OyunYoneticiKod>().KucukCemberlerdeTextgosterme();
    }
}
