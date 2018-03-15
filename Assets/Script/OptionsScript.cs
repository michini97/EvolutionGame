using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour {

	private Scrollbar scrollbar;
	private Toggle musicTog;
	private Toggle sfxTog;
	private MusicBackground music;

	// Use this for initialization
	void Start () {
		scrollbar = GameObject.Find("Scrollbar").GetComponent<Scrollbar>();
		musicTog = GameObject.Find("MusicToggle").GetComponent<Toggle>();
		sfxTog = GameObject.Find("SFXToggle").GetComponent<Toggle>();
		music = GameObject.Find("Music").GetComponent<MusicBackground>();

		if (music) {
			scrollbar.value = music.GetVolume();
			musicTog.isOn = music.IsMusicPlaying();
			sfxTog.isOn = music.PlaySFX();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
