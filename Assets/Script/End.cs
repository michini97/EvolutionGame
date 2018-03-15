using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End : MonoBehaviour {

	private Text endingText;

	// Use this for initialization
	void Start () {
		endingText = GameObject.Find("EndingText").GetComponent<Text>();
		StartCoroutine(Done());
	}

    void Update() {
        if (Input.GetKeyDown("space")) {
            GameObject.Destroy(GameObject.Find("Music"));
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator Done() {
        yield return new WaitForSeconds(3.0f);
        endingText.text = "Press \'spacebar\' to return to Start screen";
    }
}
