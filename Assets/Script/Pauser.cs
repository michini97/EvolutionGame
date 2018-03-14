using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pauser : MonoBehaviour {

    // private static Pauser pause;
    private Canvas canvas;
    private bool active = false;
    private int startScreen = 5;

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
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
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
    }

    public void PauseGame(bool canvasOn = true, float scale = 0.0f)
    {
        canvas.enabled = canvasOn;
        active = true;
        Time.timeScale = scale;
    }

    public bool IsActive()
    {
        return active;
    }

    public void Quit()
    {
        GameObject.Destroy(GameObject.Find("GameMaster"));
        SceneManager.LoadScene("StartPage");
        ResumeGame();
    }
}
