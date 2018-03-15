using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {
    private MusicBackground music;

	// Use this for initialization
	void Start () {
        music = GameObject.Find("Music").GetComponent<MusicBackground>();
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play()
    {
        music.GameStart();
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

    public void UpdateVolume() {
        Scrollbar scrollbar = GameObject.Find("Scrollbar").GetComponent<Scrollbar>();
        music.SetVolume(scrollbar.value);
    }

    public void ToggleMusic() {
        music.Toggle();
    }

    public void ToggleSFX() {
        music.ToggleSFX();
    }

    // for option canvas
    public void Done() {
        Canvas options = GameObject.Find("Options").GetComponent<Canvas>();
        Canvas pause = GameObject.Find("Pause").GetComponent<Canvas>();
        options.enabled = false;
        pause.enabled = true;
    }
}
