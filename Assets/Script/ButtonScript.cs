using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void StartPage()
    {
        SceneManager.LoadScene(0);
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Highscore()
    {
        SceneManager.LoadScene("HighScore");
    }

    public void NextLevel() {
        LevelManager lvlman = GameObject.Find("Planet").GetComponent<LevelManager>();
        SceneManager.LoadScene(lvlman.GetLevel() + 1);
    }
}
