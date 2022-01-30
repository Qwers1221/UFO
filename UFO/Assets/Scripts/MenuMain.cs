using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BtnDonate()
    {
        Application.OpenURL("https://www.youtube.com/");
    }

    public void BtnExit()
    {
        Application.Quit();
    }
    public void BtnPlay()
    {
        SceneManager.LoadScene("game");
    }
    public void BtnSettings()
    {

    }
}
