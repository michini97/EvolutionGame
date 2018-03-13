using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicBackground : MonoBehaviour {

    //public Slider MusicVolume;
    //public AudioSource myMusic;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    //private void Update()
    //{
    //    myMusic.volume = MusicVolume.value;
    //}


}
