using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnamenuKontrolKod : MonoBehaviour
{
   void Start()
    {
    //PlayerPrefs.DeleteAll();
    }

    public void oyunaGit()
    {
        int Kayitlilevel = PlayerPrefs.GetInt("kayit");

        if (Kayitlilevel == 0)
        {
            SceneManager.LoadScene(Kayitlilevel + 1);
        }
        else
        {
            SceneManager.LoadScene(Kayitlilevel);
        }
       
    }

    public void cik()
    {
        Application.Quit();
    }


}
