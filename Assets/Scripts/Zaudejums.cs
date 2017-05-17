﻿using UnityEngine;
using System.Collections;

public class Zaudejums : MonoBehaviour {

    public Transform canvas;

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvas.gameObject.activeInHierarchy == false)
            {
                canvas.gameObject.SetActive(true);
                Time.timeScale = 0;
                AudioListener.volume = 0;
            }
            else
            {
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1;
                AudioListener.volume = 1;
            }
        }
	}
}
