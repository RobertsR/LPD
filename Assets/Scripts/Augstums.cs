using UnityEngine;
using System.Collections;

public class Augstums : MonoBehaviour {

    public Transform canvas;

    void Start() {
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }

	// Update is called once per frame
	void Update () {

        var PiekabeL = GameObject.Find("RiepaLaba").transform.position.y;
        var PiekabeK = GameObject.Find("RiepaKreisa").transform.position.y;
        var SkyCarWheelFrontLeft = GameObject.Find("SkyCarWheelFrontLeft").transform.position.y;
        var SkyCarWheelFrontRight = GameObject.Find("SkyCarWheelFrontRight").transform.position.y;
        var SkyCarWheelRearLeft = GameObject.Find("SkyCarWheelRearLeft").transform.position.y;
        var SkyCarWheelRearRight = GameObject.Find("SkyCarWheelRearRight").transform.position.y;

        if (PiekabeL < 0.7 || PiekabeK < 0.7)
        {
            Zaudejums();
        }
        else if (SkyCarWheelFrontLeft < 0.4 || SkyCarWheelFrontRight < 0.4 || SkyCarWheelRearLeft < 0.4 || SkyCarWheelRearRight < 0.4)
        {
            Zaudejums();
        }

	}

    public void Zaudejums()
    {
        canvas.gameObject.SetActive(true);
        Time.timeScale = 0;
        AudioListener.volume = 0;

    }
}
