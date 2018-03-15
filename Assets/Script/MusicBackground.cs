using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicBackground : MonoBehaviour {

    //public Slider MusicVolume;
    //public AudioSource myMusic;

    private float volume = 0.5f;
    private bool playSFX = true;
    private AudioSource src;
    private static MusicBackground music;

    public AudioClip startMusic;
    public AudioClip gameMusic;

    private void Awake()
    {
        if (music != null && music != this)
        {
            Destroy(this.gameObject);
        } else
        {
            music = this;
        }
        DontDestroyOnLoad(gameObject);
        // DontDestroyOnLoad(transform.gameObject);
        src = gameObject.GetComponent<AudioSource>();

        src.clip = startMusic;
        src.volume = volume;
        src.loop = true;
        src.Play();
    }

    //private void Update()
    //{
    //    myMusic.volume = MusicVolume.value;
    //}

    public void SetVolume(float newVolume) {
        volume = newVolume;
        src.volume = volume;
    }

    public void Toggle() {
        src.mute = !src.mute;
    }

    public void ToggleSFX() {
        playSFX = !playSFX;
    }

    public bool PlaySFX() {
        return playSFX;
    }

    public void GameStart() {
        // src.Stop();
        src.clip = gameMusic;
        src.Play();
    }

    public float GetVolume() {
        return volume;
    }
}
