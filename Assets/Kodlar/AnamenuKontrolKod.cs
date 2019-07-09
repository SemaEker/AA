using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnamenuKontrolKod : MonoBehaviour
{
    public void oyunaGit()
    {
        SceneManager.LoadScene("Level1");
    }

    public void cik()
    {
        Application.Quit();
    }


}
