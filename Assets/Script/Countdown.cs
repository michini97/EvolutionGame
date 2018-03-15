using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;

public class Countdown : MonoBehaviour {

	private Text txt;
	private bool active = true;
	private Pauser pauser;

    // for script
    
    private string pickUpTxt = "Pick up controller";
	private Animation anim;

	// Use this for initialization
	void Start () {
		txt = GameObject.Find("CountdownText").GetComponent<Text>();
		StartCoroutine(Script());

		pauser = GameObject.Find("Pause").GetComponent<Pauser>();
		pauser.PauseGame(false, 1.0f);

		anim = GameObject.Find("CountdownText").GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void StartGame() {
		Destroy(GameObject.Find("StartLevelCanvas"));
		pauser.ResumeGame();
	}

	IEnumerator Script() {
		txt.fontSize = 30;

		txt.text = pickUpTxt;

		yield return new WaitForSecondsRealtime(1.0f);

		StartCoroutine(Counting(3));
	}

	IEnumerator Counting(int time) {
		txt.fontSize = 60;

		while (time > 0) {
			txt.text = time.ToString();

			Debug.Log("About to animate");
			anim.Play("CountdownAnim");
			Debug.Log(time);
			yield return new WaitForSecondsRealtime(1.0f);
			time--;
		}
		if (time == 0) {
			Debug.Log("Start!");
			StartGame();
		}
	}

	public bool IsActive() {
		return active;
	}
}
