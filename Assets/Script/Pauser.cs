using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pauser : MonoBehaviour {

    private static Pauser pause;
    private Canvas canvas;
    private bool active = false;
    private int startScreen = 5;

    private void Awake()
    {
        if (pause != null)
        {
            GameObject.Destroy(pause);
        } else
        {
            pause = this;
        }
        DontDestroyOnLoad(this);
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    // Use this for initialization
    void Start () {
		
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
        canvas.enabled = false;
        active = false;
        Time.timeScale = 1.0f;
    }

    void PauseGame()
    {
        canvas.enabled = true;
        active = true;
        Time.timeScale = 0.0f;
    }

    public bool IsActive()
    {
        return active;
    }

    public void Quit()
    {
        SceneManager.LoadScene(startScreen);
        ResumeGame();
    }
}
