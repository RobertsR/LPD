using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuPogas : MonoBehaviour {

    public void SaktPoga(string newLevel)
    {
        SceneManager.LoadScene(newLevel);
    }

    public void IzietPoga()
    {
        Application.Quit();
    }
}
