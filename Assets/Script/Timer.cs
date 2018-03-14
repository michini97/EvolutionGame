using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

    public Text timer;
    private float startTime;
    private bool active = false;
    private float levelTime = 0.0f;
    private float t = 0;

	// Use this for initialization
    private void Awake() {

    }

	void Start () {
        timer = GameObject.Find("TimerText").GetComponent<Text>();
        timer.text = "0:0";
    }
	
	// Update is called once per frame
	void Update () {
		if (active) {
	        t = (Time.time - startTime) + levelTime;
			string minutes = ((int) t / 60).ToString();
	        string seconds = (t % 60).ToString("f1");

	        timer.text = minutes + ":" + seconds;
		}
	}

	public void TurnOn() {
        startTime = Time.time;
		active = true;
	}

	public void TurnOff() {
		levelTime = t;
		t = 0;
		active = false;
	}

	public float GetTime() {
		return levelTime;
	}

	public void EndTimer() {
        CubeInfo.cubeInfo.UpdateTime(levelTime);
        active = false;
	}
}
