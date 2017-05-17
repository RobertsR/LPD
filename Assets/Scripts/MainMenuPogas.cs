using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuPogas : MonoBehaviour {

    public Transform canvas;

    public void SaktPoga(string newLevel)
    {
        SceneManager.LoadScene(newLevel);
    }

    public void IzietPoga()
    {
        Application.Quit();
    }

    public void MainMenuPoga(string newLevel)
    {
        SceneManager.LoadScene(newLevel);
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }

    public void Turpinat()
    {
        canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }
    public void MeginatVelreiz()
    {
        Time.timeScale = 1;
        AudioListener.volume = 1;
        SceneManager.LoadScene("Main_Scene");
    }
}
