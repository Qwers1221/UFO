using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour {

    public GameObject menuPause;

	// Use this for initialization
	void Start () {
        menuPause.SetActive(false);
        Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp("Pause") && Time.timeScale!=0)
        {
            Time.timeScale = 0;
            menuPause.SetActive(true);
        }
	}

    public void BtnContinue()
    {
        Time.timeScale = 1;
        menuPause.SetActive(false);
    }

    public void BtnRestart()
    {
        SceneManager.LoadScene("game");
    }

    public void BtnDonate()
    {
        Application.OpenURL("https://www.youtube.com/");
    }

    public void BtnExit()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
