using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pauser : MonoBehaviour {

    // private static Pauser pause;
    private Canvas canvas;
    private Canvas options;

    private bool active = false;
    private int startScreen = 5;
    private Timer timeCounter;

    // private void Awake()
    // {
    //     if (pause != null)
    //     {
    //         GameObject.Destroy(pause);
    //     } else
    //     {
    //         pause = this;
    //     }
    //     DontDestroyOnLoad(this);
    //     canvas = GetComponent<Canvas>();
    //     canvas.enabled = false;
    // }

    private void Awake() {
        options = GameObject.Find("Options").GetComponent<Canvas>();
        canvas = GetComponent<Canvas>();
        options.enabled = false;
        canvas.enabled = false;

        timeCounter = GameObject.Find("GameUI").GetComponent<Timer>();
    }

    // Use this for initialization
    void Start () {
        // canvas = GetComponent<Canvas>();
        // canvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space"))
        {
            if (!active)
            {
                PauseGame();
            } else
            {
                ResumeGame();
            }
        }
	}

    public void ResumeGame() {
        Debug.Log("Resume!!");
        canvas.enabled = false;
        active = false;
        Time.timeScale = 1.0f;
        timeCounter.TurnOn();
    }

    public void PauseGame(bool canvasOn = true, float scale = 0.0f)
    {
        canvas.enabled = canvasOn;
        active = true;
        Time.timeScale = scale;
        timeCounter.TurnOff();
    }

    public bool IsActive()
    {
        return active;
    }

    public void Quit()
    {
        MusicBackground music = GameObject.Find("Music").GetComponent<MusicBackground>();
        GameObject.Destroy(GameObject.Find("GameMaster"));
        music.StartPage();
        SceneManager.LoadScene("StartPage");
        ResumeGame();
    }

    public void Options() {
        canvas.enabled = false;
        options.enabled = true;
    }
}
