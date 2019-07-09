using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCemberKod : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    GameObject oyunYonetici;
    bool hareketkontrol = false;
    
   
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        oyunYonetici = GameObject.FindGameObjectWithTag("oyunyoneticitag");
    }

    
    void FixedUpdate()
    { if (!hareketkontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "donencembertag")
        {
            transform.SetParent(col.transform);
            hareketkontrol = true;
        }

        if (col.tag == "kucukcembertag")
        {
            oyunYonetici.GetComponent<OyunYoneticiKod>().OyunBitti();
        }
       
    }
    
   
}
