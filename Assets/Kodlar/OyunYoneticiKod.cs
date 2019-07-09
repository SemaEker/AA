using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunYoneticiKod : MonoBehaviour
{
    GameObject donenCember;
    GameObject anaCember;
    public Animator animator;
    public Text DonencemberLevel;
    public Text bir;
    public Text iki;
    public Text uc;
    public int Kactanekucukcemberolsun;
    bool kontrol = true;

    void Start()
    {
        donenCember = GameObject.FindGameObjectWithTag("donencembertag");
        anaCember = GameObject.FindGameObjectWithTag("anacembertag");
        DonencemberLevel.text = SceneManager.GetActiveScene().name;
        if( Kactanekucukcemberolsun <2)
        {
            bir.text = Kactanekucukcemberolsun + "";
        }
        else if ( Kactanekucukcemberolsun <3)
        {
            bir.text = Kactanekucukcemberolsun + "";
            iki.text = (Kactanekucukcemberolsun - 1) + "";
        }
        else
        {
            bir.text = Kactanekucukcemberolsun + "";
            iki.text = (Kactanekucukcemberolsun - 1) + "";
            uc.text = (Kactanekucukcemberolsun - 2) + "";
        }
      
    }
    public void KucukCemberlerdeTextgosterme()
     {
        Kactanekucukcemberolsun--;

        if (Kactanekucukcemberolsun < 2)
        {
            bir.text = Kactanekucukcemberolsun + "";
            iki.text = "";
            uc.text = "";
        }
        else if (Kactanekucukcemberolsun < 3)
        {
            bir.text = Kactanekucukcemberolsun + "";
            iki.text = (Kactanekucukcemberolsun - 1) + "";
            uc.text = "";
        }
        else
        {
            bir.text = Kactanekucukcemberolsun + "";
            iki.text = (Kactanekucukcemberolsun - 1) + "";
            uc.text = (Kactanekucukcemberolsun - 2) + "";
        }
        if(Kactanekucukcemberolsun == 0)
        {
            StartCoroutine(YeniLevel());
        }
    }

    IEnumerator YeniLevel()
    {
        donenCember.GetComponent<Dondurme>().enabled = false;
        anaCember.GetComponent<AnaCemberKod>().enabled = false;
        yield return new WaitForSeconds(0.5f);

        if(kontrol)
        {
            animator.SetTrigger("Yenilevel");
            yield return new WaitForSeconds(1.4f);

            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);
        }
        
    }

    public void OyunBitti()
    {
        StartCoroutine(Cagrilanmetot());
    }

    IEnumerator Cagrilanmetot()
    {
        donenCember.GetComponent<Dondurme>().enabled = false;
        anaCember.GetComponent<AnaCemberKod>().enabled = false;
        animator.SetTrigger("Oyunbitti");
        kontrol = false;
        

        yield return new WaitForSeconds(1);//1 saniye bekle

        SceneManager.LoadScene("Anamenu");
    }
}
