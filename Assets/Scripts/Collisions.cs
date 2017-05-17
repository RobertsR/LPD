using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Collisions : MonoBehaviour {

    bool CarFinish = false;
    bool PiekabeFinish = false;
    public Transform canvas;

    byte Level = 1;
    Vector3 Level1 = new Vector3(14.2f, 0f, 16.8f);
    Vector3 Level2 = new Vector3(-68.5f, 0f, 99.2f);
    Vector3 Level3 = new Vector3(2.08f, 0f, 159.57f);
    Vector3 Finish2 = new Vector3(19.1f, 0.8049872f, 182f);
    Vector3 Finish3 = new Vector3(9.3f, 0.8049872f, 340.7f);

    public Text laiks;
    float time = 0;

    //Level 1 = 14.2 0 16.8

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(gameObject.name + " collided with" + col.gameObject.name);
    }
    void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "Car" && other.gameObject.name == "Finish")
        {
            CarFinish = true;
            if (Level == 1)
            {
                GameObject.Find("Piekabe_Masina").transform.position = Vector3.Lerp(GameObject.Find("Piekabe_Masina").transform.position, Level2, 1);
                GameObject.Find("Finish").transform.position = Vector3.Lerp(other.gameObject.transform.position, Finish2, 1);
                Level += 1;
            }
            else if (Level == 2)
            {
                GameObject.Find("Piekabe_Masina").transform.position = Vector3.Lerp(GameObject.Find("Piekabe_Masina").transform.position, Level3, 1);
                GameObject.Find("Finish").transform.position = Vector3.Lerp(Finish3, Finish3, 1);
                Level += 1;
            }
            else if (Level == 3)
            {
                laiks.text = "Patērētais laiks: " + string.Format("{0:0.00}", time);
                canvas.gameObject.SetActive(true);
                Time.timeScale = 0;
                AudioListener.volume = 0;
                //Level += 1;
            }


        }

    }

    void Update()
    {
        time += Time.deltaTime;
        //Debug.Log("Laiks = " + time + "      Limenis = " + Level);

    }

}
